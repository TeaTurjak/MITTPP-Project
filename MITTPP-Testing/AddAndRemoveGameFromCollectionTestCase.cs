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
    public class AddAndRemoveGameFromCollectionTestCase
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
        public void TheAddAndRemoveGameFromCollectionTestCaseTest()
        {
            driver.Navigate().GoToUrl("https://www.hcl.hr/");
            driver.FindElement(By.LinkText("Prijavi se")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("mittpptestiranje@gmail.com");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("Y6mpAJ5VTkE5Ymc");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Name("submit")).Click();
            driver.FindElement(By.LinkText("Igre")).Click();
            driver.FindElement(By.Id("filter-search")).Click();
            driver.FindElement(By.Id("filter-search")).Clear();
            driver.FindElement(By.Id("filter-search")).SendKeys("Star Wars");
            driver.FindElement(By.Id("quick-filter-submit")).Click();
            driver.FindElement(By.XPath("//div[@id='post-93896']/div[2]/p[3]/a")).Click();
            driver.FindElement(By.LinkText("Kolekcija")).Click();
            driver.FindElement(By.LinkText("Ukloni iz kolekcije")).Click();
            driver.FindElement(By.LinkText("Odjavi se")).Click();
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
