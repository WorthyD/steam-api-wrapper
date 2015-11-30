using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SteamApiWrapper
{
    public abstract class Request : IRequest
    {
        public string ApiKey { get; set; }

        public Helpers.SteamUrlBuilder urlBuilder { get; set; }
        public Request()
        {
            urlBuilder = new Helpers.SteamUrlBuilder();
        }

        internal virtual string GetServiceUrl(ServiceConfiguration configuration)
        {
            throw new NotSupportedException();
        }



        public async Task<SteamApiWrapper.Response> ExecuteRequest(SteamApiWrapper.Response responseObject, object parameters, string requestBaseUrl)
        {
            string fullRequestUrl = string.Format("{0}{1}", requestBaseUrl, GetQueryString(parameters));



            HttpClient client = new HttpClient();

            var result = await client.GetAsync(fullRequestUrl);

            responseObject.RawResponse = await result.Content.ReadAsStringAsync();
            responseObject.Status = result.StatusCode;


            return responseObject;
        }

        public string GetQueryString(object obj)
        {
            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue(obj, null) != null
                             select p.Name + "=" + p.GetValue(obj, null).ToString();

            return String.Join("&", properties.ToArray());
        }


    }

    public abstract class Request<T> : Request
    {
    }


    public abstract class ListRequest : Request
    {
        public int Count { get; set; }
        public int MaxLength { get; set; }
    }

    public abstract class ListRequest<T> : ListRequest
    {
    }
}
