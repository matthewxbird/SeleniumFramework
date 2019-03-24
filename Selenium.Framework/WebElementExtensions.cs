using OpenQA.Selenium;
namespace Selenium.Framework
{
    public static class WebElementExtensions
    {
        public static string GetInputBoxValue(this IWebElement element)
        {
            return element.GetAttribute("value");
        }
    }
}
