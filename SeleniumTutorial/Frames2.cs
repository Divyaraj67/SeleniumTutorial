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
    internal class Frames2
    {
        public static void Main1(String[] args)
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.globalsqa.com/demo-site/frames-and-windows/#iFrame");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            IWebElement frames = driver.FindElement(By.XPath("//iframe[@name='globalSqa']"));
            driver.SwitchTo().Frame(frames);
            Thread.Sleep(2000);
            IWebElement frameImage = driver.FindElement(By.XPath("//*[@id='portfolio_items']/div[1]/a/div/div/div[1]/img"));
            frameImage.Click();
           
        }
    }
}
