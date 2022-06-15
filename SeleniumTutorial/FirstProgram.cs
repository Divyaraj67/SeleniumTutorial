using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace SeleniumTutorial
{
    class FirstProgram
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\3rdparty\\chrome");

        }
        [Test]
        public void test()
        {
            driver.Url = "https://www.google.co.in";
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
        

    }
}
