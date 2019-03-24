using FluentAssertions;
using Framework.ExampleTest.GoogleTests.Root;
using OpenQA.Selenium;
using Selenium.Framework;
using Xunit;

namespace Framework.ExampleTest.GoogleTests.Homepage
{
    public class Tests : TestBase
    {
        private PageObject _page;

        public Tests()
        {
            _page = new PageObject(_driver, "https://www.google.co.uk");
        }

        [Fact]
        public void CanLoadPageAndSearch()
        {
            _page.Navigate();

            var title = _page.GetTitle();
            title.Should().Be("Google");

            var searchBox = _page.GetSearchBox();
            searchBox.SendKeys("Hello Google");

            var value = searchBox.GetInputBoxValue();
            value.Should().Be("Hello Google");

            searchBox.Submit();

            var searchResultPageTitle = _page.GetTitle();

            searchResultPageTitle.Should().Be("Hello Google - Google Search");
        }
    }
}
