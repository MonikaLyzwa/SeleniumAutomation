using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    [TestFixture]
    class Program
    {

        //Create the reference for our browser
        IWebDriver _driver = null;
        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()
        {
            //Create the reference for our browser
            _driver = new ChromeDriver(); //You had local variable that was different to the global one.
            //Navigate to Google page
            _driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {

            IWebElement element = _driver.FindElement(By.Name("q"));

            //Perform Ops
            element.SendKeys("executeautomation");

            Console.WriteLine("Executed Test");
        }

        [TearDown]
        public void CleanUp()
        {
            _driver?.Quit(); //_driver.Close() only closes the browser's window. To fully close the driver, release and kill the process you have to call _driver.Quit()
            Console.WriteLine("Close the browser");
        }
    }
}
