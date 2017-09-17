using OpenQA.Selenium;

namespace SeleniumFirst
{
    public class Base
    {
        public IWebDriver Driver { get; set; }

        ~Base()
        {
            Driver?.Quit();
        }
    }
}