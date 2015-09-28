using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamApiWrapper
{
    public abstract class Response<T> where T : new()
    {

        public T Request { get; set; }

        public Response()
        {
            Request = new T();
        }

        public Response(T request)
        {
            Request = request;
        }

    }
}
