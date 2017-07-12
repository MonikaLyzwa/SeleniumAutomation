using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {

        //Create the reference for our browser
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize ()
        {
            //Create the reference for our browser
            IWebDriver driver = new ChromeDriver();
            //Navigate to Google page
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {

            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Ops
            element.SendKeys("executeautomation");

            Console.WriteLine("Executed Test");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Close the browser");
        }
    }
}
