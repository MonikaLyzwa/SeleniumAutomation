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
        private IWebDriver driver;

        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()
        {
            //Create the reference for our browser
            _driver = new ChromeDriver(); //You had local variable that was different to the global one.
            //Navigate to Google page
            _driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //Title
            SeleniumSetMethods.SelectDropDown(_driver, "TitleId", "Mr.", "Id");

            //Initial
            SeleniumSetMethods.EnterText(_driver, "Initial", "executeautomation", "Name");

            Console.WriteLine("The value from my Title is:" + SeleniumGetMethods.GetText(_driver, "TitleId", "Id", "Id"));

            Console.WriteLine("The value from my Initial is:" + SeleniumGetMethods.GetText(_driver, "Initial", "Name", "Name"));

            //Click
            SeleniumSetMethods.Click(_driver, "Save", "Name", "Name");
            
        }

        [TearDown]
        public void CleanUp()
        {
            _driver?.Quit(); //_driver.Close() only closes the browser's window. To fully close the driver, release and kill the process you have to call _driver.Quit()
            Console.WriteLine("Close the browser");
        }
    }
}
