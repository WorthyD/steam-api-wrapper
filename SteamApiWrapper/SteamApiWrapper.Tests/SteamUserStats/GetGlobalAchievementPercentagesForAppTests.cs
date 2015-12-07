using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SteamApiWrapper.Tests.SteamUserStats
{
    [TestClass]
    public class GetGlobalAchievementPercentagesForAppTests 
    {

        public  SteamApiWrapper.SteamUserStats.GetGlobalAchievementPercentagesForAppRequest r;
        public GetGlobalAchievementPercentagesForAppTests()
        {
            r = new SteamApiWrapper.SteamUserStats.GetGlobalAchievementPercentagesForAppRequest();
        }


        [TestMethod]
        public async Task GetAchievementPercentages()
        {

            r.GameId = 440;
            var response = await r.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
            Assert.IsTrue(response.GlobalAchievementPercentages.achievements.Count > 0);
        }

        [TestMethod]
        public async Task GetAchievementPercentagesNoStats()
        {
            r.GameId = 0;
            var response = await r.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.NotFound);
        }

    }
}
