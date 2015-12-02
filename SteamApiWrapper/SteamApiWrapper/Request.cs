﻿using Newtonsoft.Json;
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



        public abstract Helpers.SteamUrlBuilder.Interface UrlInterface { get; }
        public abstract Helpers.SteamUrlBuilder.Version ApiVersion { get; }
        public abstract string UrlPath { get; }


        private Helpers.SteamUrlBuilder urlBuilder { get; set; }

        public Request()
        {
            urlBuilder = new Helpers.SteamUrlBuilder();
        }

        internal virtual string GetServiceUrl(ServiceConfiguration configuration)
        {
            throw new NotSupportedException();
        }





        public async Task<SteamApiWrapper.Response> ExecuteRequest(SteamApiWrapper.Response responseObject, object parameters)
        {
            string requestBaseUrl = urlBuilder.BuildRequestUrl(this.UrlInterface, this.ApiVersion, this.UrlPath);
            string fullRequestUrl = string.Format("{0}?{1}", requestBaseUrl, GetQueryString());


            HttpClient client = new HttpClient();

            var result = await client.GetAsync(fullRequestUrl);

            responseObject.RawResponse = await result.Content.ReadAsStringAsync();
            responseObject.Status = ResponseStatus.Convert(result.StatusCode.ToString());
            responseObject.StatusMessage = responseObject.Status.ToString();
            responseObject.Convert();

            return responseObject;
        }

        public string GetQueryString()
        {
            var properties = from p in this.GetType().GetProperties()
                             where p.GetValue(this, null) != null && Attribute.IsDefined(p, typeof(QueryParameter))
                             select p.Name + "=" + p.GetValue(this, null).ToString();

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


    public class QueryParameter : System.Attribute
    {

    }


}
