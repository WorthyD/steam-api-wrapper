using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamApiWrapper.SteamUserStats
{
    public class GetGlobalAchievementPercentagesForAppResponse : Response<GetGlobalAchievementPercentagesForAppRequest>
    {
        public Models.GlobalAchievementPercentages GlobalAchievementPercentages { get; set; }
        public GetGlobalAchievementPercentagesForAppResponse()
        { }
        public GetGlobalAchievementPercentagesForAppResponse(GetGlobalAchievementPercentagesForAppRequest request) : base(request) { }

    }
}
