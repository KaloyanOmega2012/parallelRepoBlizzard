
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ParallelSeleniumWebDriver
{
    [TestFixture, Parallelizable(ParallelScope.Children)]
    public class UnitTest1 
    {
        private readonly string blizUrl = "http://eu.blizzard.com/en-gb/";
       // public IWebDriver drv;

        //[OneTimeSetUp,NonParallelizable]
        
        //public void Initialize()
        //{
        //    //Base baseClass = new Base();
             
            
        //}


        [Test]
        public void ClickBtnGames()
        {
            //a
            IWebDriver drv = new ChromeDriver();

            drv.Navigate().GoToUrl(blizUrl);
            drv.Manage().Window.Maximize();
            HomePage HomePage = new HomePage(drv);
            HomePage.TopNavigation.ButtonGames.Click();

            Assert.AreEqual("GAMES", drv.FindElement(By.CssSelector(".flashTextOver.pagetitle")).Text);
        }

        [Test]
        public void ClickBtnCompany()
        {
            IWebDriver drv = new ChromeDriver();

            drv.Navigate().GoToUrl(blizUrl);
            drv.Manage().Window.Maximize();
            HomePage HomePage = new HomePage(drv);
            HomePage.TopNavigation.ButtonCompany.Click();

            Assert.AreEqual("COMPANY", drv.FindElement(By.CssSelector(".flashTextOver.landingtitle")).Text);
        }

        [Test]
        public void ClickBtnJobs()
        {
            IWebDriver drv = new ChromeDriver();

            drv.Navigate().GoToUrl(blizUrl);
            drv.Manage().Window.Maximize();
            HomePage HomePage = new HomePage(drv);
            HomePage.TopNavigation.ButtonJobs.Click();

            Assert.AreEqual("View Job Openings", drv.FindElement(By.CssSelector("Button.hide.inline-xs")).Text);

        }

        [Test]
        public void ClickBtnSupport()
        {
            IWebDriver drv = new ChromeDriver();

            drv.Navigate().GoToUrl(blizUrl);
            drv.Manage().Window.Maximize();
            HomePage HomePage = new HomePage(drv);
            HomePage.TopNavigation.ButtonSupport.Click();
            Assert.AreEqual("What can we help you with?", drv.FindElement(By.CssSelector(".home-header-content.hide-on-mobile")).Text);
        }

        [Test]
        public void ClickBtnShop()
        {
            IWebDriver drv = new ChromeDriver();

            drv.Navigate().GoToUrl(blizUrl);
            drv.Manage().Window.Maximize();
            HomePage HomePage = new HomePage(drv);
            HomePage.TopNavigation.ButtonShop.Click();

            Assert.AreEqual("Shop", drv.FindElement(By.CssSelector(".text-home")).Text);
        }

        //[OneTimeTearDown]
        //public void TearDown()
        //{
        //    drv.Instance.Quit();
        //}
    }

}
