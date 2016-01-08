using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SteamApiWrapper.Tests.SteamUserStats
{
    [TestClass]
    public class GetSchemaForGameTests : BaseTest
    {
        public SteamApiWrapper.SteamUserStats.GetSchemaForGameRequest req;

        public GetSchemaForGameTests()
        {
            req = new SteamApiWrapper.SteamUserStats.GetSchemaForGameRequest(base.APIKey);
        }
        [TestMethod]
        public async Task GetSchemaForGameTest()
        {
            req.appid = 440;
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
        }
    }
}
