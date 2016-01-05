using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SteamApiWrapper.Tests.SteamUserStats
{
    [TestClass]
    public class GetUserStatsForGameTests : BaseTest
    {
        public SteamApiWrapper.SteamUserStats.GetUserStatsForGameRequest req;

        public GetUserStatsForGameTests()
        {
            req = new SteamApiWrapper.SteamUserStats.GetUserStatsForGameRequest(base.APIKey);
            req.SteamId = 76561198025095151;
        }
        [TestMethod]
        public async Task GetUserStatsTest()
        {
            req.appid = 440;
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
        }
    }
}
