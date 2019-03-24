using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace Selenium.Framework
{
    public class GoogleDriver
    {
        public IWebDriver Get()
        {
            var driverLocation = GetDriverLocation();
            var driverService = ChromeDriverService.CreateDefaultService(driverLocation);
            var options = new ChromeOptions();
            var commandTimeout = TimeSpan.FromSeconds(30);
            return new ChromeDriver(driverService, options, commandTimeout);
        }

        public string GetDriverLocation()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            return Path.GetDirectoryName(path);
        }
    }
}
