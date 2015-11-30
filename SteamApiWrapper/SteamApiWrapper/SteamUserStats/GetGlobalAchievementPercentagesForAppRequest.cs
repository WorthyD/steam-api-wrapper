using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SteamApiWrapper.SteamUserStats
{
    public class GetGlobalAchievementPercentagesForAppRequest : Request
    {
        public const string URL_KEY = "GetGlobalAchievementPercentagesForApp";
        public int GameId { get; set; }

        public GetGlobalAchievementPercentagesForAppRequest() : base()
        {
        }

        public async Task<GetGlobalAchievementPercentagesForAppResponse> GetResponse()
        {

            string requestUrl = urlBuilder.BuildRequestUrl(Helpers.SteamUrlBuilder.Interface.ISteamUserStats, 
                Helpers.SteamUrlBuilder.Version.v2, URL_KEY);

            string fullRequestUrl = string.Format("{0}{1}", requestUrl, this.BuildRequestQuery());
            string responseString = await Helpers.WebRequestHelper.ExecuteGetRequest(fullRequestUrl);

            var globalAchievements =   JsonConvert.DeserializeObject<Models.GlobalAchievementPercentages>(responseString);

            var response = new GetGlobalAchievementPercentagesForAppResponse();
            response.GlobalAchievementPercentages = globalAchievements;

            return response;


        }
        private string BuildRequestQuery()
        {
            List<string> query = new List<string>();
            query.Add(string.Format("gameid={0}", this.GameId));

            return string.Format("?{0}", String.Join("&", query.ToArray()));
        }


    }
}
