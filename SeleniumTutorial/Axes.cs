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


namespace SeleniumTutorial
{
    internal class Axes
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            driver.Manage().Window.Maximize();

            #region WebElements
            //following axes
            IWebElement firstName = driver.FindElement(By.XPath("//label[text()='Name']/following::input[1]"));
            //preceding axes
            IWebElement lastName = driver.FindElement(By.XPath("//label[text()='Email']/preceding::input[@id='lastName']"));
            //descendant axes
            IWebElement email = driver.FindElement(By.XPath("//div[@id='userEmail-wrapper']/descendant::input[1]"));
            //preceding-sibling , parent, child
            // IWebElement rbMale = driver.FindElement(By.XPath("//label[text()='Mobile']/parent::div/parent::div/preceding-sibling::div[1]/child::div[2]/child::div[1]/child::input[contains(@value,'Male')]"));
             IWebElement rbMale = driver.FindElement(By.XPath("//label[text()='Mobile']/parent::div/parent::div/preceding-sibling::div[1]/child::div[2]/child::div[1]/child::label"));

            //following-sibling
            IWebElement mobile = driver.FindElement(By.XPath("//div[@id='genterWrapper']/following-sibling::div[1]/child::div[2]/child::input[@type='text']"));
            //ancestor
            IWebElement subject = driver.FindElement(By.XPath("//div[@id='hobbiesWrapper']/ancestor::form/child::div[6]/descendant::div[8]/child::input"));

            #endregion

            #region sendKeys
            firstName.SendKeys("Divyarajsinh");
            Thread.Sleep(1000);
            lastName.SendKeys("Dodia");
            Thread.Sleep(1000);
            email.SendKeys("divyaraj@gmail.com");
            Thread.Sleep(1000);
            rbMale.Click();
            Thread.Sleep(1000);
            mobile.SendKeys("8752367895");
            Thread.Sleep(1000);
            subject.SendKeys("abc");
            Thread.Sleep(1000);
            

            #endregion sendKeys
        }
    }
}
