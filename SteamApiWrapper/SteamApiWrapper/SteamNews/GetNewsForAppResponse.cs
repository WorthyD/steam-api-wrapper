using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamApiWrapper.SteamNews
{
    public class GetNewsForAppResponse : Response {
        public Models.ApplicationNews.AppNews AppNews { get; set; }
        public GetNewsForAppResponse()
        {
        }
        public override void Convert()
        {
            throw new NotImplementedException();
        }

        public GetNewsForAppResponse(GetNewsForAppRequest request)  { }
    }
}

//public class PlayerGamesResponse : Response<PlayerGamesRequest>
//{
//    public Models.gamesList GamesList { get; set; }
//    public PlayerGamesResponse() { }
//    public PlayerGamesResponse(PlayerGamesRequest request) : base(request) { }
//}j