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
    internal class Alerts
    {
        public static void Main1(String[] args)
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/alerts");

            //IWebElement Simple = driver.FindElement(By.XPath("//*[@id='alertButton']"));
            //Simple.Click();
            //Thread.Sleep(2000);
            //IAlert simpleAlert = driver.SwitchTo().Alert();
            //simpleAlert.Accept();

            //Thread.Sleep(2000);

            //IWebElement Confirm = driver.FindElement(By.XPath("//*[@id='confirmButton']"));
            //Confirm.Click();
            //Thread.Sleep(2000);
            //IAlert ConfirmAlert = driver.SwitchTo().Alert();
            ////ConfirmAlert.Accept();
            //ConfirmAlert.Dismiss();
            //Thread.Sleep(2000);

          //  Actions actions = new Actions(driver);
          //  IWebElement Prompt = driver.FindElement(By.XPath("//*[@id='promtButton']"));
          //  Prompt.Click();
          //  Thread.Sleep(2000);
          //  driver.SwitchTo().Alert().Accept();
          //  Thread.Sleep(1000);
          // //PromptAlert.SendKeys("Hii");
          ////  actions.SendKeys("Hii");
          //  Thread.Sleep(2000);
            
        }

    }
}
