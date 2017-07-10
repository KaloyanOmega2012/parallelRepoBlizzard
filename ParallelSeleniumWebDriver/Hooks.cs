using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSeleniumWebDriver
{
    [TestFixture]
    public class Hooks:Base
    {
        public Hooks()
        {
            Driver = new ChromeDriver();
        }
    }
}
