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
using System.Drawing;

namespace SeleniumTutorial
{
    internal class Enable_Display
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");

            IWebElement chkenbl = driver.FindElement(By.Id("react-select-4-input"));
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(chkenbl);
            bool chk = chkenbl.Enabled;

            if(chk==false)
            {
                Console.WriteLine("Dropdown city is disabled");
            }
            else
            {
                Console.WriteLine("Dropdown city is enabled");
            }
            
            bool displaychk = chkenbl.Displayed;
            if (displaychk==true)
            {
                Console.WriteLine("Dropdown city is displayed");
            }
            else
            {
                Console.WriteLine("Dropdown city is not displayed");
            }

        }
    }
}
