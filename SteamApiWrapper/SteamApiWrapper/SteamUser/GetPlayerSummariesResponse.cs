using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamApiWrapper.SteamUser
{
    public class GetPlayerSummariesResponse : Response
    {

        public Models.PlayerSummaries.Response Players { get; set; }

        public override void Convert()
        {
            throw new NotImplementedException();
        }
    }
}
