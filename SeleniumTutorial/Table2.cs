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
    internal class Table2
    {
        static void Main1(string[] args)
        {
            //prints all following row data of specified text
            testTable tstTbl = new testTable();
            string strData = "Financial Center";
            tstTbl.tblmethod(strData);
            

        }

    }

    public class testTable
    {
        public void tblmethod(string strData)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.techlistic.com/p/demo-selenium-practice.html");
            Thread.Sleep(2000);
            IList<IWebElement> tblTd = driver.FindElements(By.XPath("//*[text()= '" + strData + "']/following-sibling::td"));
            int size = tblTd.Count();

            foreach (var tbldata in tblTd)
            {
                string str = tbldata.Text;
                Console.WriteLine(str);
            }

        }
    }

}
