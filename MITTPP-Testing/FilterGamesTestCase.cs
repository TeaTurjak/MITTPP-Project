using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class FilterGamesTestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheFilterGamesTestCaseTest()
        {
            driver.Navigate().GoToUrl("https://www.hcl.hr/");
            driver.FindElement(By.LinkText("Igre")).Click();
            driver.FindElement(By.Id("filter-platforms")).Click();
            new SelectElement(driver.FindElement(By.Id("filter-platforms"))).SelectByText("regexp:\\s+Switch");
            driver.FindElement(By.Id("filter-genre")).Click();
            new SelectElement(driver.FindElement(By.Id("filter-genre"))).SelectByText("akcijska avantura");
            driver.FindElement(By.Id("developer")).Click();
            new SelectElement(driver.FindElement(By.Id("developer"))).SelectByText("38 Studios");
            driver.FindElement(By.Id("publisher")).Click();
            new SelectElement(driver.FindElement(By.Id("publisher"))).SelectByText("11 bit Studios");
            driver.FindElement(By.XPath("//form[@id='game-filter']/div[4]/input")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
