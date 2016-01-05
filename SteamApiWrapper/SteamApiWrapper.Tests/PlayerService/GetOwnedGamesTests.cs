using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamApiWrapper.Tests.PlayerService
{
    [TestClass]
    public class GetOwnedGamesTests :BaseTest
    {
        public SteamApiWrapper.PlayerService.GetOwnedGamesRequest req;
        public GetOwnedGamesTests()
        {
            req = new SteamApiWrapper.PlayerService.GetOwnedGamesRequest(base.APIKey);
            req.SteamId = 76561198025095151;
        }

        [TestMethod]
        public async Task GetOwnedGamesTest()
        {
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
        }

        [TestMethod]
        public async Task GetOwnedGamesTestCount()
        {
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
            Assert.IsTrue(response.OwnedGames.game_count > 0);
            Assert.IsTrue(response.OwnedGames.games.Count() > 0);
        }

        [TestMethod]
        public async Task GetOwnedGamesNoDetailsTest()
        {
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
            Assert.IsTrue(response.OwnedGames.game_count > 0);
            Assert.IsTrue(response.OwnedGames.games.Count() > 0);
            var firstGame = response.OwnedGames.games.FirstOrDefault();

            Assert.IsTrue(firstGame.name == null);
        }

        [TestMethod]
        public async Task GetOwnedGamesDetailsTest()
        {
            req.include_appinfo = "1";
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
            Assert.IsTrue(response.OwnedGames.game_count > 0);
            Assert.IsTrue(response.OwnedGames.games.Count() > 0);
            var firstGame = response.OwnedGames.games.FirstOrDefault();

            Assert.IsTrue(firstGame.name != null);
        }


        [TestMethod]
        public async Task GetOwnedNoFreeToPlayTest()
        {
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
            Assert.IsTrue(response.OwnedGames.game_count > 0);
            Assert.IsTrue(response.OwnedGames.games.Count() > 0);

            var freeToPlayGame = response.OwnedGames.games.Where(x => x.appid == AppID_TeamFortressTwo).FirstOrDefault();
            Assert.IsTrue(freeToPlayGame == null);
        }

        [TestMethod]
        public async Task GetOwnedFreeToPlayTest()
        {
            req.include_played_free_games = "1";
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
            Assert.IsTrue(response.OwnedGames.game_count > 0);
            Assert.IsTrue(response.OwnedGames.games.Count() > 0);

            var freeToPlayGame = response.OwnedGames.games.Where(x => x.appid == AppID_TeamFortressTwo).FirstOrDefault();
            Assert.IsTrue(freeToPlayGame != null);
        }




    }
}
