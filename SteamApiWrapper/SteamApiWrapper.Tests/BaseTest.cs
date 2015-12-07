using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamApiWrapper.Tests
{
    public class BaseTest
    {
        public string APIKey { get { return ConfigurationManager.AppSettings["APIKey"]; } }
    }
}
