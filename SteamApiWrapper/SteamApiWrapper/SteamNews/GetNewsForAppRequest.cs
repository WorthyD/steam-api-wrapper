using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;
using SteamApiWrapper.Helpers;

namespace SteamApiWrapper.SteamNews
{
    public class GetNewsForAppRequest : ListRequest
    {
        /// <summary>
        /// Game ID
        /// </summary>
        [QueryParameter]
        public int AppId { get; set; }

        /// <summary>
        /// Result count Returned
        /// </summary>
        [QueryParameter]
        public int Count { get; set; }

        /// <summary>
        /// Length of the contents field
        /// </summary>
        [QueryParameter]
        public int MaxLength { get; set; }

        public override SteamUrlBuilder.Interface UrlInterface
        {
            get
            {
                return Helpers.SteamUrlBuilder.Interface.ISteamNews;
            }
        }

        public override SteamUrlBuilder.Version ApiVersion
        {
            get
            {
                return Helpers.SteamUrlBuilder.Version.v2;
            }
        }

        public override string UrlPath
        {
            get
            {
                return "GetNewsForApp";
            }
        }

        public GetNewsForAppRequest()
        {
            //urlBuilder = new Helpers.SteamUrlBuilder();
        }

        public async Task<GetNewsForAppResponse> GetResponse()
        {
            //string requestUrl = urlBuilder.BuildRequestUrl(, , "GetNewsForApp");

            //string fullRequestUrl = string.Format("{0}{1}", requestUrl, this.BuildRequestQuery());
            //string responseString = await Helpers.WebRequestHelper.ExecuteGetRequest(fullRequestUrl);

            //var news =   JsonConvert.DeserializeObject<Models.ApplicationNews>(responseString);

            //var response = new GetNewsForAppResponse();
            //response.AppNews = news.appnews;

            var response = new GetNewsForAppResponse();

            //var objec = await response.ExecuteRequest<Models.ApplicationNews>(null, requestUrl);
        
            response = await base.ExecuteRequest(response as Response, this) as GetNewsForAppResponse;

            return response;

        }

        //private string BuildRequestQuery()
        //{
        //    List<string> query = new List<string>();

        //    query.Add(string.Format("appid={0}", this.AppId));

        //    if (this.Count > 0)
        //    {
        //        query.Add(string.Format("count={0}", this.Count));
        //    }

        //    if (this.MaxLength > 0)
        //    {
        //        query.Add(string.Format("maxcount={0}", this.MaxLength));
        //    }

        //    return string.Format("?{0}", String.Join("&", query.ToArray()));
        //}

    }
}
