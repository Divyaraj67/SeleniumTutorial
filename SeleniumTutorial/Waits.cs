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
    internal class Waits
    {
        public static void Main1(String[] args)
        {
            implicitWait( );
           // ExplicitWait();
        }
        public static void ExplicitWait()
        {

            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://chercher.tech/practice/explicit-wait-sample-selenium-webdriver");
            IWebElement btnMain = driver.FindElement(By.Id("enable-button"));
            btnMain.Click();
            WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(9));
            IWebElement btn= webDriverWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("disable")));
            string btntxt= btn.Text;
            Console.WriteLine(btntxt);

        }

        public static void implicitWait()
        {

            WebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            string test_url = "https://chercher.tech/practice/explicit-wait-sample-selenium-webdriver";
            driver.Url = test_url;
            IWebElement dynamicElement = driver.FindElement(By.Id("alert"));
            IWebElement dynamicElement1 = driver.FindElement(By.Id("alert1"));
            dynamicElement.Click();
        }

        public static void fluentWait()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://chercher.tech/practice/explicit-wait-sample-selenium-webdriver");

            WebDriverWait FluentWait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            IWebElement btn = FluentWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("disable")));
            string btntxt = btn.Text;
            Console.WriteLine(btntxt);
        }


  
        
    }
   
}
