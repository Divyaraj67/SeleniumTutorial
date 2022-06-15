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
    internal class ForEach
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");

            IList<IWebElement> chkboxs = driver.FindElements(By.XPath("//*[contains(@class,'checkbox')]/child::label"));
            int Size = chkboxs.Count();

            foreach (WebElement cbox in chkboxs)
            {
                string cls = cbox.GetAttribute("class");
                Console.WriteLine("class of checkbox is" + cls);
            }

        }
    }
}
