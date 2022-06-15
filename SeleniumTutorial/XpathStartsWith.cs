using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTutorial
{
    internal class XpathStartsWith
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/text-box");

            #region WebElements
            IWebElement username = driver.FindElement(By.XPath("//input[starts-with(@type,'text')]"));
            IWebElement userEmail = driver.FindElement(By.XPath("//input[starts-with(@type,'email')]"));
            IWebElement address = driver.FindElement(By.XPath("//textarea[starts-with(@id,'curr')]"));
            IWebElement permanantAddress = driver.FindElement(By.XPath("//textarea[starts-with(@id,'perm')]"));
            #endregion

            #region sendKeys
            username.SendKeys("Divyaraj");
            userEmail.SendKeys("abc@gmail.com");
            address.SendKeys("Hello this is current address text area");
            permanantAddress.SendKeys("Hello this is permanent text area");
            #endregion sendKeys
        }
    }
}
