using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace nunitframework.PageObject
{
    public class ResultsPage
    {
        IWebDriver driver;
        public ResultsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How=How.LinkText,Using = "TheTechie AutomationLabs")]
        public IWebElement Resultlink { get; set; }

        public ChannelPage OpenResult()
        {
            System.Threading.Thread.Sleep(3000);
            Resultlink.Click();
            return new ChannelPage(driver);
        }
    }
}
