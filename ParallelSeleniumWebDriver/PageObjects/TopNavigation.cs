using Autofac;
using OpenQA.Selenium;
using ParallelSeleniumWebDriver.DIContainer;
using ParallelSeleniumWebDriver.PageObjects;

namespace ParallelSeleniumWebDriver
{
    public class TopNavigation
    {
        private string baseSelector = ".navigation";
        private IWebDriver driver;

        public TopNavigation(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Button ButtonGames => DIContainerConfig.Config().Resolve<Button>
            (new TypedParameter(typeof(IWebDriver), driver),
            new NamedParameter("baseSelector", baseSelector),
            new NamedParameter("elementSelector", ".navgames"));


        public Button ButtonCompany => DIContainerConfig.Config().Resolve<Button>
           (new TypedParameter(typeof(IWebDriver), driver),
           new NamedParameter("baseSelector", baseSelector),
           new NamedParameter("elementSelector", ".navgames"));

        //      public Button ButtonCompany => new Button(driver,baseSelector, ".navcompany");
        //      public Button ButtonJobs => new Button(driver,baseSelector, ".navcommunity");
        //      public Button ButtonSupport => new Button(driver,baseSelector, ".navsupport");
        //      public Button ButtonShop => new Button(driver,baseSelector, ".navstore");

    }
}