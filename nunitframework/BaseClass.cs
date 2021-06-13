using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace nunitframework
{
    public class BaseClass
    {
        IWebDriver driver;
        public IWebDriver intit()
        {
            driver = new ChromeDriver();
            driver.Url = "https://login.yahoo.com/?.src=ym&pspid=1197806870&activity=header-signin&.lang=en-IN&.intl=in&.done=https%3A%2F%2Fmail.yahoo.com%2Fd%3F.lang%3Den-IN";
            return driver;
        }

    }
}
