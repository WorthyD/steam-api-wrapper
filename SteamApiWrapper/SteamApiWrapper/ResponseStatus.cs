using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamApiWrapper
{
    public class ResponseStatus
    {
        public enum ResponseStatusCode
        {
            Ok = 100,
            InvalidRequest = 201,
            LimitExceded = 202,
            Unauthorized = 300,
            AuthFailure = 301,
        }
        public static ResponseStatusCode Convert(string status)
        {
            return (ResponseStatusCode)Enum.Parse(typeof(ResponseStatusCode), status, true); ;
        }
    }
}
