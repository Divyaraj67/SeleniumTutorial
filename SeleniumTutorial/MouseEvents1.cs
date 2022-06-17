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
    internal class MouseEvents1
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            Actions action = new Actions(driver);
            driver.Navigate().GoToUrl("https://demoqa.com/buttons");
            WebElement btndblclick = (WebElement)driver.FindElement(By.Id("doubleClickBtn"));
            action.DoubleClick(btndblclick).Perform();
            Thread.Sleep(2000);
            WebElement rgtclick = (WebElement)driver.FindElement(By.Id("rightClickBtn"));
            action.ContextClick(rgtclick).Perform();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/button")).Click();
            Thread.Sleep(2000);
            driver.Quit();

        }

    }
}
