using OpenQA.Selenium;
using System;

namespace Selenium.Framework
{
    public abstract class TestBase : IDisposable
    {
        protected IWebDriver _driver;
        protected TestBase()
        {
            _driver = new GoogleDriver().Get();
        }

        public void Dispose()
        {
            _driver.Quit();
        }
    }
}
