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
    internal class Dropdown
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://chercher.tech/practice/practice-dropdowns-selenium-webdriver");
            driver.Manage().Window.Maximize();


            //select by text
            IWebElement products = driver.FindElement(By.XPath("//select[@id='first']"));
            products.Click();
            Thread.Sleep(1000);
            SelectElement selectElement = new SelectElement(products);
            selectElement.SelectByText("Iphone");
            Thread.Sleep(2000);



            //select by value
            IWebElement animals = driver.FindElement(By.Id("animals"));
            animals.Click();
            Thread.Sleep(1000);
            SelectElement oselect = new SelectElement(animals);
            oselect.SelectByValue("babycat");
            Thread.Sleep(2000);



            //select by index
            IWebElement customDropdown = driver.FindElement(By.XPath("//button[@id='custom']"));
            customDropdown.Click();
            Thread.Sleep(2000);
            IWebElement customOption = driver.FindElement(By.XPath("//ul[contains(@class,'drop')]/child::li[3]"));
            customOption.Click();

            // multiple options
            IWebElement multiSelect = driver.FindElement(By.XPath("//select[@id='second']"));
            Thread.Sleep(1000);
            SelectElement multiple = new SelectElement(multiSelect);
            multiple.SelectByText("Pizza");
            multiple.SelectByText("Bonda");
            Thread.Sleep(2000);
            multiple.DeselectAll();

            IList<IWebElement> multi = multiple.Options;
            int iSize = multi.Count;
            for(int i=0; i<iSize;i++)
            {
                String sValue = multi.ElementAt(i).Text;
                Console.WriteLine(sValue);
            }



        }
    }
}
