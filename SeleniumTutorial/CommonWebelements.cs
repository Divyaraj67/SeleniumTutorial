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
using System.Drawing;

namespace SeleniumTutorial
{
    internal class CommonWebelements
    {
        static void Main1(string[] args)
        {
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/webtables");
            driver.Manage().Window.Maximize();
            IWebElement click = driver.FindElement(By.Id("edit-record-1"));
            click.Click();
            IWebElement clickFirstName = driver.FindElement(By.Id("firstName"));
            clickFirstName.Click();
            clickFirstName.Clear();
            clickFirstName.SendKeys("Divyaraj");
            bool display = driver.FindElement(By.Id("firstName")).Displayed; 

            Console.WriteLine( "First Name is Displayed?"+ display);

            bool enable = driver.FindElement(By.Id("firstName")).Enabled;
            Console.WriteLine("First Name is Enabled?" + enable);
            Thread.Sleep(2000);
            IWebElement submit = driver.FindElement(By.Id("submit"));
            submit.Submit();
            string tagName = submit.TagName;
            Console.WriteLine("TagName of Submit is"+ tagName);
            //string Cssvalue = submit.GetCssValue();
            string attribute = submit.GetAttribute("class");
            Console.WriteLine("Class of submit button is" + attribute);             
            Console.WriteLine(submit.Size);
            Point point = submit.Location;
            Console.WriteLine("X cordinate : " + point.X + "Y cordinate: " + point.Y);
        }
    }
}
