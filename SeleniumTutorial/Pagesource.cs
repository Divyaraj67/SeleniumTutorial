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
    internal class Pagesource
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/webtables";
            
            String PageSource = driver.PageSource;
            
            //Console.WriteLine("Page Source of the page is : " + PageSource);

             if(PageSource.Contains("currentColor"))
            {
                Console.WriteLine("PageSource contains the given text");
            }
            else
            {
                Console.WriteLine("PageSource does not contain given text");
            }

        }
    }
}
