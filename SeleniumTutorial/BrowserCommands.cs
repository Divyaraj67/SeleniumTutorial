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
    internal class BrowserCommands
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/webtables";
            String title = driver.Title;
            int titleLength = driver.Title.Length;
            Console.WriteLine("Page Title is : " + title);
            Console.WriteLine("Title Length is : " + titleLength);
            String pageUrl = driver.Url;
            int urlLength = pageUrl.Length;
            Console.WriteLine("Url of the page is : " + pageUrl);
            Console.WriteLine("Url Length is : " + urlLength);
            String PageSource = driver.PageSource;
            int pageSourceLength = driver.PageSource.Length;
            //Console.WriteLine("Page Source of the page is : " + PageSource);
            Console.WriteLine("Pagesource Length is : " + pageSourceLength);
            

        }
    }
}
