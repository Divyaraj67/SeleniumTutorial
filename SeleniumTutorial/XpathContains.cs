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
    internal class XpathContains
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/text-box");

            #region WebElements
            IWebElement username = driver.FindElement(By.XPath("//*[contains(@type,'text') and contains(@id,'Name') ]"));
            IWebElement userEmail = driver.FindElement(By.XPath("//*[contains(@type,'email')  ]"));
            IWebElement address = driver.FindElement(By.XPath("//*[contains(@id,'curr') and contains(@class,'form-control') ]"));
            IWebElement permanantAddress = driver.FindElement(By.XPath("//*[contains(@id,'perm') and contains(@class,'form-control') ]"));
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
