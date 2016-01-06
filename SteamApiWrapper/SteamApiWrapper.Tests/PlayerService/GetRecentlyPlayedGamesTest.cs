using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamApiWrapper.Tests.PlayerService
{
    [TestClass]
    public class GetRecentlyPlayedGamesTests : BaseTest
    {
        public SteamApiWrapper.PlayerService.GetRecentlyPlayedGamesRequest req;
        public GetRecentlyPlayedGamesTests()
        {
            req = new SteamApiWrapper.PlayerService.GetRecentlyPlayedGamesRequest(base.APIKey);
            req.SteamId = 76561198025095151;
        }

        [TestMethod]
        public async Task GetRecentlyPlayedGamesTest()
        {
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
        }

        [TestMethod]
        public async Task GetRecentlyPlayedGamesTestCount()
        {
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
            Assert.IsTrue(response.RecentlyPlayedGames.total_count > 0);
            Assert.IsTrue(response.RecentlyPlayedGames.games.Count() > 0);
        }

       




    }
}
