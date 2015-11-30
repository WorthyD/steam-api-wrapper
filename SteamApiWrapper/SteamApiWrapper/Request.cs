using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
