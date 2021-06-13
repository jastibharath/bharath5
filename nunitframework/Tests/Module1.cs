using nunitframework.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using nunitframework.Basetest;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;
using excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Linq;

namespace nunitframework.Tests
{ 
    [TestFixture]

    
    class Module1: BaseTest
    {

        public void drawborder(IWebElement element,IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].style.border='3px solid blue'", element);
        }
        public string title(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string title=js.ExecuteScript("return document.title;").ToString();
            return title;
        }
        public void clickjs(IWebElement element, IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", element);
        }
        public void alertjs(IWebDriver driver, string msg)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("alert('"+msg+"')");
        }
        public void refreshjs(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("history.go(0)");
        }
        public void scrolldown(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
        }
        public void scrollup(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,-document.body.scrollHeight)");
        }
        public void zoompage(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.body.style.zoom='150%'");
        }
        public IWebElement WaitForElement(IWebDriver driver, By locator, int timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            return driver.FindElement(locator);
        }
        public void bootstrapdropdown(By drp1, By options, string value)
        {
            IWebElement drpdwn = driver.FindElement(drp1);
            drpdwn.Click();
            ReadOnlyCollection<IWebElement> drpoptions=driver.FindElements(options);
            foreach (IWebElement option in drpoptions)
            {
                if (option.Text.Equals(value))
                {
                    option.Click();
                    break;
                }
            }




        }

        public IWebElement waitForElementFluent(IWebDriver driver, By locator, int timeout, int polling)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(timeout);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(polling);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found";
            IWebElement element = fluentWait.Until(x => x.FindElement(locator));
            return element;

        }
        public void selectdrpvalue(IWebElement element,string text)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByText(text);
        }
        [Test]
        public void TestMethod1()
        {
            driver.Url = "https://www.amazon.in/";

        }

     }
}
