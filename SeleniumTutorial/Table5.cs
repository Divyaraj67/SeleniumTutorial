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
    internal class Table5
    {




        static void Main(string[] args)
        {
            //Prints all headers of table
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.techlistic.com/p/demo-selenium-practice.html");


            String beforeRowXpath = "//*[@id='customers']/tbody/tr[";
            string afterRowXpath = "]/td[1]";
            

            IWebElement tbl = driver.FindElement(By.XPath("//table[@id='customers']"));
            IList<IWebElement> tblRow = new List<IWebElement>(tbl.FindElements(By.TagName("tr")));
            int row_count = tblRow.Count();

            for (int i = 2; i <= row_count; i++)
            {
                IList<IWebElement> colCount = new List<IWebElement>(tbl.FindElements(By.XPath("//table[@id='customers']/tbody/tr[" + i + "]/td")));
                int column_count = colCount.Count();

                    string actualXpath = beforeRowXpath + i + afterRowXpath;
                    IWebElement tbldata = driver.FindElement(By.XPath(actualXpath));
                    Console.WriteLine(tbldata.Text);
            
            }

        }
    }
}
