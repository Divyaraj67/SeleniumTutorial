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
    internal class MouseEvents2
    {
        static void Main1(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.softwaretestingmaterial.com/selenium-tutorial/");
            driver.Manage().Window.Maximize();
            

            Actions action = new Actions(driver);

            Thread.Sleep(2000);
            IWebElement Hoverele = driver.FindElement(By.XPath("//span[@class='nav-drop-title-wrap']"));
            action.MoveToElement(Hoverele).Perform();
      
            IWebElement Linkbtn = driver.FindElement(By.XPath("//li[@id='menu-item-16993']/child::a[1]"));
            action.MoveToElement(Linkbtn).Click().Perform();
            Thread.Sleep(2000);
            driver.Quit();

        }
    }
}
