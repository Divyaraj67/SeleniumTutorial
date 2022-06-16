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
        //program to print desired column data
        static void Main1(string[] args)
        {

            Console.WriteLine("Please enter column which you want to print");
            string data = Console.ReadLine();
            int ColNo = Convert.ToInt32(data);
            tbldataCol TblcolData = new tbldataCol();
            TblcolData.Coldata(ColNo);

            //*[@id="customers"]/tbody/tr[2]/td[1]
            //*[@id="customers"]/tbody/tr[3]/td[1]

            //*[@id="customers"]/tbody/tr[2]/td[2]
            //*[@id="customers"]/tbody/tr[3]/td[2]
        }
    }
    public class tbldataCol
    {
        public void Coldata(int ColumnNumber)
        {
           
                //Prints all headers of table
                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.techlistic.com/p/demo-selenium-practice.html");


                String beforeRowXpath = "//*[@id='customers']/tbody/tr[";
                string afterRowXpath = "]/td[";
                string afterColXpath = "]";


                IWebElement tbl = driver.FindElement(By.XPath("//table[@id='customers']"));
                IList<IWebElement> tblRow = new List<IWebElement>(tbl.FindElements(By.TagName("tr")));
                int row_count = tblRow.Count();

                int colno = ColumnNumber;
                for(int i=2;i<=row_count;i++)
                {
                string actualXpath = beforeRowXpath + i + afterRowXpath + colno + afterColXpath;
                IWebElement tbldata = driver.FindElement(By.XPath(actualXpath));
                Console.WriteLine(tbldata.Text);

                }
               
                 
            

                    //string actualXpath = beforeRowXpath + colno + afterRowXpath;
                    //IWebElement tbldata = driver.FindElement(By.XPath(actualXpath));
                    //Console.WriteLine(tbldata.Text);

            
        }
    }
}
