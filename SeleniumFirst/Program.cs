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
        static void Main(string[] args)
        {
            //Create the reference for our browser
            IWebDriver driver = new ChromeDriver();

            //Navigate to Google page
            driver.Navigate().GoToUrl("http://www.google.com");
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Ops
            element.SendKeys("executeautomation");
            driver.Close();
        }
    }
}
