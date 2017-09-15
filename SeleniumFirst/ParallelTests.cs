using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using SeleniumParallelTest;
using OpenQA.Selenium;

namespace SeleniumFirst
{
    [TestFixture]
    public class FirefoxParallelTests : Hooks
    {
        [Test]
        public void FirefoxTest()
        {
            Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Driver.FindElement(By.Name("UserName")).SendKeys("execute");
            Driver.FindElement(By.Name("UserName")).SendKeys("automation");
            Driver.FindElement(By.Name("Login"));
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true), "The text selenium does not exist");

        }

        [TestFixture]
        public class ChromeParallelTests : Hooks
        {
         [Test]
         public void ChromeTest()
         {
              Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
              Driver.FindElement(By.Name("UserName")).SendKeys("execute");
              Driver.FindElement(By.Name("UserName")).SendKeys("automation");
              Driver.FindElement(By.Name("Login"));
              Assert.That(Driver.PageSource.Contains("Automation"), Is.EqualTo(true), "The text automation does not exist");
          }
        }
    }
}
