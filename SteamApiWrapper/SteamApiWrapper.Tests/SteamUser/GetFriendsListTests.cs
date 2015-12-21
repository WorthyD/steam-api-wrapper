using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SteamApiWrapper.Tests.SteamNews
{
    [TestClass]
    public class GetFriendsListTests : BaseTest
    {
        public SteamApiWrapper.SteamUser.GetFriendListRequest req;

        public GetFriendsListTests()
        {
            req = new SteamApiWrapper.SteamUser.GetFriendListRequest(base.APIKey);
            req.SteamId = 76561198025095151
            ;

        }

        [TestMethod]
        public async Task GetFriendsTest()
        {
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
        }

        [TestMethod]
        public async Task GetProfilesTest()
        {
            //req.ProfileIds.Add(76561198023113346);
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
        }

        [TestMethod]
        public async Task GetFriendsNoResult()
        {
            req.SteamId = 0;
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
        }



    }
}
