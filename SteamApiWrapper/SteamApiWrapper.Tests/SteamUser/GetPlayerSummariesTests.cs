using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SteamApiWrapper.Tests.SteamNews
{
    [TestClass]
    public class GetPlayerSummariesTests : BaseTest
    {
        public SteamApiWrapper.SteamUser.GetPlayerSummariesRequest req;

        public GetPlayerSummariesTests()
        {
            req = new SteamApiWrapper.SteamUser.GetPlayerSummariesRequest(base.APIKey);
            req.ProfileIds = new List<long>()
            {
                76561198025095151
            };

        }

        [TestMethod]
        public async Task GetProfileTest()
        {
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
        }

        [TestMethod]
        public async Task GetNewsAppTestCount()
        {
            var response = await req.GetResponse();
        }


    
    }
}
