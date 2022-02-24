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
    public class AddPCSpecificationsToProfileTestCase
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
        public void TheAddPCSpecificationsToProfileTestCaseTest()
        {
            driver.Navigate().GoToUrl("https://www.hcl.hr/");
            driver.FindElement(By.Id("authActions")).Click();
            driver.FindElement(By.LinkText("Prijavi se")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("mittpptestiranje@gmail.com");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("Y6mpAJ5VTkE5Ymc");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Name("submit")).Click();
            driver.FindElement(By.XPath("//img[@alt='Korisnik']")).Click();
            driver.FindElement(By.LinkText("Profil")).Click();
            driver.FindElement(By.LinkText("Uljepšaj svoj profil")).Click();
            driver.FindElement(By.XPath("//form[@id='profileSettingsForm']/div[8]/div/div/div")).Click();
            driver.FindElement(By.XPath("//div[@id='mainContainer']/div[4]/div/div[2]")).Click();
            driver.FindElement(By.XPath("//form[@id='profileSettingsForm']/div[8]/div/div")).Click();
            driver.FindElement(By.Id("settingsRAM")).Click();
            driver.FindElement(By.Id("settingsMON")).Click();
            driver.FindElement(By.XPath("//div[@id='mainContainer']/div[4]/div/div[2]")).Click();
            driver.FindElement(By.Id("settingsPER")).Clear();
            driver.FindElement(By.Id("settingsPER")).SendKeys("miš");
            driver.FindElement(By.XPath("//form[@id='profileSettingsForm']/div[8]/div/div/div[7]")).Click();
            driver.FindElement(By.Id("settingsOstalo")).Clear();
            driver.FindElement(By.Id("settingsOstalo")).SendKeys("slušalice");
            driver.FindElement(By.XPath("//input[@value='SPREMI']")).Click();
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
