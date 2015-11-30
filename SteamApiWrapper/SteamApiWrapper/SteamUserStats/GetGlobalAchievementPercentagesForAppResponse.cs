using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamApiWrapper.SteamUserStats
{
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
