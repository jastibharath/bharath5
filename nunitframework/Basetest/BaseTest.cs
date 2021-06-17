using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace nunitframework.Basetest
{
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver driver;
        [SetUp]
        public void initilize()
        {
            //ChromeOptions options = new ChromeOptions();
            //options.AddArguments("--disable-notifications");
            //string location = @"C:\abc362021";
            //Dictionary<string, string> preferences = new Dictionary<string, string>();
            //preferences["download.default_directory"] = location;
            //ChromeOptions options = new ChromeOptions();
            //options.AddAdditionalCapability("prefs", preferences);
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        [TearDown]
        public void close()
        {
            driver.Quit();
        }

    }
}
