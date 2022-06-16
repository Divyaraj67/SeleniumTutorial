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
using System.Collections.ObjectModel;

namespace SeleniumTutorial
{
    internal class WindowHandle1
    {
        public static void Main1(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var browbtn = driver.FindElement(By.XPath("//img[@class='banner-image']"));
            string winHandle1 = driver.CurrentWindowHandle;
            Console.WriteLine("Parent/Original window handle is "+winHandle1);
            
            Console.WriteLine("Number of windows opened currently is "+driver.WindowHandles.Count);
            foreach(var item in driver.WindowHandles)
            {
                Console.WriteLine(item);
            }

            browbtn.Click();
            string winHandle2 = driver.CurrentWindowHandle;
            Console.WriteLine("Child window handle is " + winHandle2);

            Console.WriteLine("Number of windows opened currently is " + driver.WindowHandles.Count);
            foreach (var item in driver.WindowHandles)
            {
                Console.WriteLine(item);
            }


            driver.SwitchTo().Window(winHandle2);
            IWebElement registration =  driver.FindElement(By.XPath("//*[text()='Go To Registration ']"));
            registration.Click();

        }
    }
}
