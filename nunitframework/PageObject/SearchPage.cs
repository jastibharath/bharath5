using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace nunitframework.PageObject
{
    public class SearchPage
    {
        IWebDriver driver;
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath,Using = "//*[@name='search_query']")]
        public IWebElement Searchbox { get; set; }

        [FindsBy(How = How.Id, Using = "search-icon-legacy")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How=How.PartialLinkText,Using = "Customer")]

        public IWebElement Signin { get; set; }


        public ResultsPage NavigatetoResults()
        {
            Searchbox.SendKeys("bakappa n");
            SearchButton.Click();
            return new ResultsPage(driver);
        }
        public void signinaction()
        {
            Signin.Click();
        } 
    }
}
