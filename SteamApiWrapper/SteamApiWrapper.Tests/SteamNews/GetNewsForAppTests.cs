using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SteamApiWrapper.Tests.SteamNews
{
    [TestClass]
    public class GetNewsForAppTests
    {
        [TestMethod]
        public  async Task GetNewsAppTest()
        {
            var r = new SteamApiWrapper.SteamNews.GetNewsForAppRequest();

            r.AppId = 440;
            r.Count = 3;
            r.MaxLength = 3;

            var response = await r.GetResponse();

            Assert.IsTrue(response.AppNews.newsitems.Count > 0);
        }
    }
}
