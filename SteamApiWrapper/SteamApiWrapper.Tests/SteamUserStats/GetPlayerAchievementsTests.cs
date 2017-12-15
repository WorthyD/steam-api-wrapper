using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SteamApiWrapper.Tests.SteamUserStats
{
    [TestClass]
    public class GetPlayerAchievementsTests : BaseTest
    {
        public SteamApiWrapper.SteamUserStats.GetPlayerAchievementsRequest req;

        public GetPlayerAchievementsTests()
        {
            req = new SteamApiWrapper.SteamUserStats.GetPlayerAchievementsRequest(base.APIKey);
            req.SteamId = 76561198025095151;
        }

        [TestMethod]
        public async Task GetAchievementTest()
        {
            //req.appid = 284850;
            req.appid = 240;
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public async Task GetAchievementFailNoAppIdTest()
        {

            var response = await req.GetResponse();
        }
    }
}
