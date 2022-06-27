using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumTutorial
{
    internal class Frames
    {
        public static void Main1(String[] args)
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.guru99.com/handling-iframes-selenium.html");
            driver.Manage().Window.Maximize();
            IList<IWebElement> frames = driver.FindElements(By.XPath("//iframe"));
            int size = frames.Count();
            Console.WriteLine("This webpage is having total "+size+" frames");
        }
    }
}
