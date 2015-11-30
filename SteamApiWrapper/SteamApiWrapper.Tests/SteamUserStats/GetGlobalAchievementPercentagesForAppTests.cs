using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SteamApiWrapper.Tests.SteamUserStats
{
    [TestClass]
    public class GetGlobalAchievementPercentagesForAppTests
    {
        [TestMethod]
        public async Task GetAchievementPercentages()
        {
            var r = new SteamApiWrapper.SteamUserStats.GetGlobalAchievementPercentagesForAppRequest();

            r.GameId = 440;

            var response = await r.GetResponse();
            Assert.IsTrue(response.GlobalAchievementPercentages.achievementpercentages.achievements.Count > 0);
        }
    }
}
