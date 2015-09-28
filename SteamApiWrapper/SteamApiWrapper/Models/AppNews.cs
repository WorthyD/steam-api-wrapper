using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamApiWrapper.Models
{
    public class AppNews
    {
        public int appid { get; set; }
        public Newsitem[] newsitems { get; set; }
        
        public class Newsitem
        {
            public string gid { get; set; }
            public string title { get; set; }
            public string url { get; set; }
            public bool is_external_url { get; set; }
            public string author { get; set; }
            public string contents { get; set; }
            public string feedlabel { get; set; }
            public int date { get; set; }
            public string feedname { get; set; }
        }

    }
}


