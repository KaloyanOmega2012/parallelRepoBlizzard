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

		public Button(IWebDriver driver ,string baseSelector,string elementSelector)
		{
			element = driver.FindElement(By.CssSelector($"{baseSelector} {elementSelector}"));
		}

		public void Click()
		{
			element.Click();
		}

	}
}
