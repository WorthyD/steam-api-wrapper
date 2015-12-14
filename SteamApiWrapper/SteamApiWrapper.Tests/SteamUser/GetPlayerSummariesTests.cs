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
        public async Task GetProfilesTest()
        {
            req.ProfileIds.Add(76561198023113346);
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
            Assert.IsTrue(response.Players.Length == 2);
        }

        [TestMethod]
        public async Task GetProfileNoResult()
        {
            req.ProfileIds = new List<long>();
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
        }



    }
}
