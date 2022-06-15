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
    internal class SelectMuliCheckbox
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            driver.Manage().Window.Maximize();

            IWebElement chkbox1 = driver.FindElement(By.XPath("//input[@type='checkbox' and @value = 1]/following::label[1]"));
            IWebElement chkbox2 = driver.FindElement(By.XPath("//input[@type='checkbox' and @value = 1]/following::label[2]"));
            IWebElement chkbox3 = driver.FindElement(By.XPath("//input[@type='checkbox' and @value = 1]/following::label[3]"));

            IList<IWebElement> multi;
            multi = new List<IWebElement>();
            multi.Add(chkbox1);
            multi.Add(chkbox2);
            multi.Add(chkbox3);

            int iSize = multi.Count;

            
            for(int i=0;i<iSize;i++)
            {
                 multi.ElementAt(i).Click();
            }
        }
    }
}
