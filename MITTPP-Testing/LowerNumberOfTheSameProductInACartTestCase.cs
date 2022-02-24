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
    public class LowerNumberOfTheSameProductInACartTestCase
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
        public void TheLowerNumberOfTheSameProductInACartTestCaseTest()
        {
            driver.Navigate().GoToUrl("https://www.hcl.hr/");
            driver.FindElement(By.LinkText("Hcl shop")).Click();
            driver.Navigate().GoToUrl("https://shop.hcl.hr/");
            driver.FindElement(By.XPath("//li[@id='menu-item-213']/a")).Click();
            driver.FindElement(By.XPath("//img[contains(@src,'https://shop.hcl.hr/wp-content/uploads/2020/12/maska-jednoslojna-hcl-crna-500x625.jpg')]")).Click();
            driver.FindElement(By.XPath("//div[@id='product-1860']/div[3]/form/div/button[2]")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | xpath=//div[@id='product-1860']/div[3]/form/div/button[2] | ]]
            driver.FindElement(By.XPath("//div[@id='product-1860']/div[3]/form/div/button[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='product-1860']/div[3]/form/div/button[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='product-1860']/div[3]/form/div/button[2]")).Click();
            driver.FindElement(By.Name("add-to-cart")).Click();
            driver.FindElement(By.LinkText("Košarica")).Click();
            driver.FindElement(By.XPath("//div[@id='container']/div/div[2]/div[2]/form/table/tbody/tr[3]/td[5]/div/button")).Click();
            driver.FindElement(By.XPath("//div[@id='container']/div/div[2]/div[2]/form/table/tbody/tr[3]/td[5]/div/button")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | xpath=//div[@id='container']/div/div[2]/div[2]/form/table/tbody/tr[3]/td[5]/div/button | ]]
            driver.FindElement(By.XPath("//div[@id='container']/div/div[2]/div[2]/form/table/tbody/tr[3]/td[5]/div/button")).Click();
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
