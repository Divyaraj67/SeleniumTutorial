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
    internal class FindElements
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");

            ////// By List

           /* IList<IWebElement> chkboxs = driver.FindElements(By.XPath("//*[contains(@class,'checkbox')]/child::label"));
            int Size = chkboxs.Count();

            for (int i = 0; i < Size; i++)
            {
                string cls = chkboxs[i].GetAttribute("class");
                Console.WriteLine("Class of label " + i + " is " + cls);
            } */

            //// By Var

           var chkboxs = driver.FindElements(By.XPath("//*[contains(@class,'checkbox')]/child::label"));

           Console.WriteLine(chkboxs.Count());
        }

    }
}
