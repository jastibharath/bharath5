using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace nunitframework.PageObject
{
    public class ChannelPage
    {
        IWebDriver driver;
        public ChannelPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How=How.XPath,Using = "//div[@id='channel-header-container']//yt-formatted-string[@id='text' and @class='style-scope ytd-channel-name']")]
        public IWebElement channelname { get; set; }

        public string getchannelname()
        {
            System.Threading.Thread.Sleep(3000);
            return channelname.Text;
        }



    }
}
