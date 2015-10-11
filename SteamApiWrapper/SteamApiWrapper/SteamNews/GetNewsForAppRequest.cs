using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SteamApiWrapper.SteamNews
{
    public class GetNewsForAppRequest : ListRequest
    {
        /// <summary>
        /// Game ID
        /// </summary>
        public int AppId { get; set; }

        /// <summary>
        /// Result count Returned
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Length of the contents field
        /// </summary>
        public int MaxLength { get; set; }

        public Helpers.SteamUrlBuilder urlBuilder { get; set; }

        public GetNewsForAppRequest()
        {
            urlBuilder = new Helpers.SteamUrlBuilder();
        }

        public async Task<GetNewsForAppResponse> GetResponse()
        {
            string requestUrl = urlBuilder.BuildRequestUrl(Helpers.SteamUrlBuilder.Interface.ISteamNews, Helpers.SteamUrlBuilder.Version.v2, "GetNewsForApp");
            string fullRequestUrl = string.Format("{0}{1}", requestUrl, this.BuildRequestQuery());
            string responseString = await Helpers.WebRequestHelper.ExecuteGetRequest(fullRequestUrl);

            return null;

        }

        private string BuildRequestQuery()
        {
            List<string> query = new List<string>();

            query.Add(string.Format("appid={0}", this.AppId));

            if (this.Count > 0)
            {
                query.Add(string.Format("count={0}", this.Count));
            }

            if (this.MaxLength > 0)
            {
                query.Add(string.Format("maxcount={0}", this.MaxLength));
            }

            return string.Format("?", String.Join("&", query.ToArray()));
        }

    }
}
