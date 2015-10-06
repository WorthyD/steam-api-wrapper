﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamApiWrapper.App
{
    public class GetNewsForAppResponse : Response<GetNewsForAppRequest>
    {
        public Models.AppNews AppNews { get; set; }
        public GetNewsForAppResponse()
        {
        }

        public GetNewsForAppResponse(GetNewsForAppRequest request) : base(request) { }
    }
}

//public class PlayerGamesResponse : Response<PlayerGamesRequest>
//{
//    public Models.gamesList GamesList { get; set; }
//    public PlayerGamesResponse() { }
//    public PlayerGamesResponse(PlayerGamesRequest request) : base(request) { }
//}j