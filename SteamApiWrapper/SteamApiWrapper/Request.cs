using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamApiWrapper
{
    public abstract class Request 
    {
        public string ApiKey { get; set; }

        internal virtual string GetServiceUrl(ServiceConfiguration configuration)
        {
            throw new NotSupportedException();
        }
    }

    public abstract class Reqest<T> : Request
    {
    }
}
