using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSeleniumWebDriver.PageObjects
{
	public class Button
	{

        IWebElement element;
        private IWebDriver driver;
        private string baseSelector;
        private string elementSelector;

        public Button(IWebDriver driver ,string baseSelector,string elementSelector)
		{
            this.driver = driver;
            this.baseSelector = baseSelector;
            this.elementSelector = elementSelector;
		}

		public void Click()
		{
            element = driver.FindElement(By.CssSelector($"{baseSelector} {elementSelector}"));
            element.Click();
		}

	}
}
