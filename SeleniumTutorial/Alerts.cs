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
        public static void Main(String[] args)
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/alerts");

            IWebElement Simple = driver.FindElement(By.XPath("//*[@id='alertButton']"));
            Simple.Click();
            Thread.Sleep(2000);
            IAlert simpleAlert = driver.SwitchTo().Alert();
            simpleAlert.Accept();

            Thread.Sleep(2000);

            IWebElement Confirm = driver.FindElement(By.XPath("//*[@id='confirmButton']"));
            Confirm.Click();
            Thread.Sleep(2000);
            IAlert ConfirmAlert = driver.SwitchTo().Alert();
            //ConfirmAlert.Accept();
            ConfirmAlert.Dismiss();
            Thread.Sleep(2000);


            IWebElement Prompt = driver.FindElement(By.XPath("//*[@id='promtButton']"));
            Prompt.Click();
            IAlert PromptAlert = driver.SwitchTo().Alert();
            Thread.Sleep(1000);
            PromptAlert.SendKeys("Hii");
            Thread.Sleep(2000);
            
        }

    }
}
