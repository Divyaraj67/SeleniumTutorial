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
    internal class Table4
    {
        //program to print drsired row data
        static void Main1(string[] args)
        {
            Console.WriteLine("Please enter row which you want to print");
            string data = Console.ReadLine();
            int rownum = Convert.ToInt32(data);
            tbldata tableData = new tbldata();
            tableData.tableDataRow(rownum);
            

        }
    }
    public class tbldata
    {
        public void tableDataRow(int rowNumber)
        {
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.techlistic.com/p/demo-selenium-practice.html");


            String beforeRowXpath = "//*[@id='customers']/tbody/tr[";
            string afterRowXpath = "]";


            IWebElement tbl = driver.FindElement(By.XPath("//table[@id='customers']"));
            IList<IWebElement> tblRow = new List<IWebElement>(tbl.FindElements(By.TagName("td")));
            int row_count = tblRow.Count();


            int i = rowNumber;

            string actualXpath = beforeRowXpath + i + afterRowXpath;
            IWebElement tbldata = driver.FindElement(By.XPath(actualXpath));
            Console.WriteLine(tbldata.Text);
            Console.WriteLine("**************");
        }
    }
}
