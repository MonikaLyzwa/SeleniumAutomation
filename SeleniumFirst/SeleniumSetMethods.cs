using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
            {
                if (elementtype == "id")
                    driver.FindElement(By.Id(element)).SendKeys(value);
                if (elementtype == "LinkText");
                    driver.FindElement(By.Name(element)).SendKeys(value);

            }

        //Click into a button, checkbox, option etc.
        internal static void Click(IWebDriver driver, string element, string value, string elementtype)
        {
            if (value == "id")
                driver.FindElement(By.Id(element)).Click();
            if (value == "LinkText")
                driver.FindElement(By.Name(element)).Click();
        }

        //Selecting a dropdown control
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }

    }
}
