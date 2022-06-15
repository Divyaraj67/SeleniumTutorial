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
    internal class Table3
    {
        static void Main1(string[] args)
        {
            //Prints all headers of table
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.techlistic.com/p/demo-selenium-practice.html");


            String beforeRowXpath = "//*[@id='customers']/tbody/tr[";
            string beforeThXpath = "]/th[";
            string afterThXpath = "]";
            string afterRowXpath = "]/td[";
            string beforeColXpath = "]";

            IWebElement tbl = driver.FindElement(By.XPath("//table[@id='customers']"));
            IList<IWebElement> tblRow = new List<IWebElement>(tbl.FindElements(By.TagName("td")));
            int row_count = tblRow.Count();

            

            for (int k=1;k<2;k++)//prints headers of table
            {
                IList<IWebElement> tblTh = new List<IWebElement>(tbl.FindElements(By.TagName("th")));
                int th_count = tblTh.Count();
                for(int x=1;x<=th_count;x++)
                {
                    string ThXpath = beforeRowXpath + k + beforeThXpath+ x + afterThXpath;
                    IWebElement thdata = driver.FindElement(By.XPath(ThXpath));
                    Console.WriteLine(thdata.Text);
                }
                
                Console.WriteLine("**************");
            }

            
            for (int i=2;i<=row_count; i++)//prints rest of the data of table
            {
                IList<IWebElement> colCount = new List<IWebElement>(tbl.FindElements(By.XPath("//table[@id='customers']/tbody/tr[" + i + "]/td")));
                int column_count = colCount.Count();

                for(int j=1; j<= column_count;j++)
                {
                    string actualXpath = beforeRowXpath + i + afterRowXpath + j + beforeColXpath;
                    IWebElement tbldata = driver.FindElement(By.XPath(actualXpath));
                    Console.WriteLine(tbldata.Text);
                    
                }
                Console.WriteLine("**************");
            }

        }
    }
}
