using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamApiWrapper.App
{
    public class GetNewsForAppResponse : Response<Models.AppNews>
    {
        public Models.AppNews AppNews { get; set; }
        public GetNewsForAppResponse
    }
}

//public class PlayerGamesResponse : Response<PlayerGamesRequest>
//{
//    public Models.gamesList GamesList { get; set; }
//    public PlayerGamesResponse() { }
//    public PlayerGamesResponse(PlayerGamesRequest request) : base(request) { }
//}j