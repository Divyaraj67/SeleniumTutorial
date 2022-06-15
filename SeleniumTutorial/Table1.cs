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
    internal class Table1
    {
        static void Main1(string[] args)
        {
            //Prints all headers of table
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.techlistic.com/p/demo-selenium-practice.html");

            IWebElement tbl = driver.FindElement(By.XPath("//table[@id='customers']"));

           IList<IWebElement> tblEle = new List<IWebElement>(tbl.FindElements(By.TagName("th")));

            foreach(var Thele in tblEle)
            {
                 string strThData = Thele.Text;
                Console.WriteLine(strThData);
            }
            
        }
    }
}
