using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSeleniumWebDriver
{
	public class HomePage
	{
        private IWebDriver driver;
        private readonly string blizUrl = "http://eu.blizzard.com/en-gb/";

        public HomePage(IWebDriver driver, TopNavigation topNavigation)
        {
            this.driver = driver;
            TopNavigation = topNavigation;
        }

        public TopNavigation TopNavigation { get; }

        public void GoTo()
        {
            driver.Navigate().GoToUrl(blizUrl);
        }
    }
}
