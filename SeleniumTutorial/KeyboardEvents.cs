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
    internal class KeyboardEvents
    {
        public static void Main1(String[] args)
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/text-box");
            driver.Manage().Window.Maximize();
            Actions actions = new Actions(driver);

            IWebElement fullName = driver.FindElement(By.Id("userName"));
            fullName.SendKeys("Divyaraj");

            IWebElement email = driver.FindElement(By.Id("userEmail"));
            email.SendKeys("abc@gmail.com");

            IWebElement currentAddress = driver.FindElement(By.Id("currentAddress"));

            currentAddress.SendKeys("Gandhinagar,Gujarat");


            actions.KeyDown(Keys.Control);
            actions.SendKeys("a");
            actions.KeyUp(Keys.Control);
            actions.Build().Perform();

            actions.KeyDown(Keys.Control);
            actions.SendKeys("c");
            actions.KeyUp(Keys.Control);
            actions.Build().Perform();

            actions.SendKeys(Keys.Tab);
            actions.Build().Perform();

            actions.KeyDown(Keys.Control);
            actions.SendKeys("v");
            actions.KeyUp(Keys.Control);
            actions.Build().Perform();

            actions.SendKeys(Keys.Tab);
            IWebElement submit =driver.FindElement(By.Id("submit"));
            submit.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
        }
    }
}
