using OpenQA.Selenium;

namespace Framework.ExampleTest.GoogleTests.Root
{
    public class PageObject
    {
        private readonly IWebDriver _driver;
        private readonly string _pageRoot;
        public PageObject(IWebDriver driver, string root)
        {
            _pageRoot = root;
            _driver = driver;
        }

        public void Navigate()
        {
            _driver.Navigate().GoToUrl(_pageRoot);
        }

        public string GetTitle()
        {
            return _driver.Title;
        }

        public IWebElement GetSearchBox()
        {
            return _driver.FindElement(By.Name("q"));
        }
    }
}
