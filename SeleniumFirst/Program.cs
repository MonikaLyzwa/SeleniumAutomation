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
        //IWebPropertiesCollection.PropertiesCollection.driver _PropertiesCollection.PropertiesCollection.driver = null;
        //private IWebPropertiesCollection.PropertiesCollection.driver PropertiesCollection.PropertiesCollection.driver;

        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            //Create the reference for our browser
            //PropertiesCollection.driver = new ChromeDriver.driver(); //You had local variable that was different to the global one.
            //Navigate to Google page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //Title
            SeleniumSetMethods.SelectDropDown( "TitleId", "Mr.", PropertyType.Id);

            //Initial
            SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

            Console.WriteLine("The value from my Title is:" + SeleniumGetMethods.GetText("TitleId", PropertyType.Id));

            Console.WriteLine("The value from my Initial is:" + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //Click
            SeleniumSetMethods.Click("Save", "Name", PropertyType.Name);
            
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver?.Quit(); //_PropertiesCollection.driver.Close() only closes the browser's window. To fully close the PropertiesCollection.driver, release and kill the process you have to call _PropertiesCollection.driver.Quit()
            Console.WriteLine("Close the browser");
        }
    }
}
