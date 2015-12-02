using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SteamApiWrapper.Tests.SteamNews
{
    [TestClass]
    public class GetNewsForAppTests
    {
        public SteamApiWrapper.SteamNews.GetNewsForAppRequest req;

        public GetNewsForAppTests()
        {
            req = new SteamApiWrapper.SteamNews.GetNewsForAppRequest();
            req.AppId = 440;
            req.Count = 3;
            req.MaxLength = 3;


        }

        [TestMethod]
        public async Task GetNewsAppTest()
        {
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.OK);
            Assert.IsTrue(response.AppNews.NewsItems.Count > 0);
        }

        [TestMethod]
        public async Task GetNewsAppTestCount()
        {
            var response = await req.GetResponse();
            Assert.IsTrue(response.AppNews.NewsItems.Count == 3);
        }


        [TestMethod]
        public async Task GetNewsAppTestMaxLength()
        {
            var response = await req.GetResponse();
            bool indexFixed = false;
            foreach (var n in response.AppNews.NewsItems)
            {
                int i = n.contents.IndexOf('.');
                if (n.contents.IndexOf('.') >= 3 && n.contents.Length < 7)
                {
                    indexFixed = true;
                }
            }

            Assert.IsTrue(indexFixed);
        }



        [TestMethod]
        public async Task GetNewsAppTestFailure()
        {
            req.AppId = 0;
            var response = await req.GetResponse();
            Assert.IsTrue(response.Status == ResponseStatus.ResponseStatusCode.NotFound);
        }
    }
}
