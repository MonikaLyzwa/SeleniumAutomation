using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumFirst
{
    [TestFixture]
    public class FirefoxParallelTests : Base
    {
        public FirefoxParallelTests()
        {
            var pathToBinary = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            Driver = new FirefoxDriver(
                new FirefoxOptions()
                {
                    BrowserExecutableLocation = pathToBinary
                });
        }

        [Test]
        public void FirefoxTest()
        {
            Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Driver.FindElement(By.Name("UserName")).SendKeys("execute");
            Driver.FindElement(By.Name("Password")).SendKeys("automation");
            var element = Driver.FindElement(By.Name("Login")).FindElement(By.Name("Login"));

            element.Click();
            Assert.That(Driver.PageSource.Contains("User Form"), Is.EqualTo(true), "The text automation does not exist");
        }

        [TestFixture]
        public class ChromeParallelTests : Base
        {
            public ChromeParallelTests()
            {
                Driver = new ChromeDriver();
            }

            [Test]
            public void ChromeTest()
            {
                Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
                Driver.FindElement(By.Name("UserName")).SendKeys("execute");
                Driver.FindElement(By.Name("Password")).SendKeys("automation");
                var element = Driver.FindElement(By.Name("Login")).FindElement(By.Name("Login"));

                element.Click();
                Assert.That(Driver.PageSource.Contains("User Form"), Is.EqualTo(true), "The text automation does not exist");
            }
        }
    }
}