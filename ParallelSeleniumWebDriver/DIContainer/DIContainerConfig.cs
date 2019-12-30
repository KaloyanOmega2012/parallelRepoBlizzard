using Autofac;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ParallelSeleniumWebDriver.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSeleniumWebDriver.DIContainer
{
    public static class DIContainerConfig
    {
        public static IContainer Config()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ChromeDriver>().As<IWebDriver>().SingleInstance();
            //builder.RegisterType<Button>().AsSelf().UsingConstructor(typeof(IWebDriver), typeof(string), typeof(string));
            builder.RegisterType<Button>().AsSelf();
            builder.RegisterType<HomePage>().AsSelf();
            builder.RegisterType<TopNavigation>().AsSelf();


            return builder.Build();
        }
    }
}
