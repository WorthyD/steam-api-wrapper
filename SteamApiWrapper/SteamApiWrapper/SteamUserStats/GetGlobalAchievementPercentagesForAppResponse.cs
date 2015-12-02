using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamApiWrapper.SteamUserStats
{
    //http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?appid=440&count=3&maxlength=300&format=json
    public class GetGlobalAchievementPercentagesForAppResponse : Response
    {
        public Models.GlobalAchievementPercentages GlobalAchievementPercentages { get; set; }
        public GetGlobalAchievementPercentagesForAppResponse()
        { }
        public override void Convert()
        {
            throw new NotImplementedException();
        }

        public GetGlobalAchievementPercentagesForAppResponse(GetGlobalAchievementPercentagesForAppRequest request) :base() { }

    }
}
