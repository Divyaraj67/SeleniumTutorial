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
    internal class Selected
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            driver.Manage().Window.Maximize();

            IWebElement radiobtn = driver.FindElement(By.XPath("//input[@type='radio' and @value = 'Male']/following::label[1]"));
            radiobtn.Click();
            
            bool check = radiobtn.Selected;

            if (check== true)
            {
                Console.WriteLine("Radio button is selected");
            }
            else
            {
                Console.WriteLine("Radio Button is not selected");
            }
        }
    }
}
