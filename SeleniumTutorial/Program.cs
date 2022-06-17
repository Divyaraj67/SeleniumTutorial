using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace SeleniumTutorial
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //    //driver.Navigate().GoToUrl("https://demoqa.com/text-box");

            //  //  driver.Manage().Window.Maximize();

            //    //#region Web elements

            //    //IWebElement fullname = driver.FindElement(By.Id("abc"));

            //    //#endregion Web elements



            //    //fullname.SendKeys("abc");


            //    ///---Elemets by ID---//

            //    //driver.FindElement(By.Id("userName")).SendKeys("Divyaraj");
            //    //driver.FindElement(By.Id("userEmail")).SendKeys("abc@gmail.com");
            //    //driver.FindElement(By.Id("currentAddress")).SendKeys("Hello this is address textbox");
            //    //driver.FindElement(By.Id("permanentAddress")).SendKeys("Hello this is permenant address box");
            //    //driver.FindElement(By.Id("submit")).Click();
            //    //driver.Quit();


            //    ///---Elements by class---///
            //    //IWebDriver driver = new ChromeDriver();
            //    //driver.Navigate().GoToUrl("https://demoqa.com/text-box");
            //    //WebElement Name = (WebElement)driver.FindElement(By.ClassName("mr-sm-2 form-control"));
            //    //Name.SendKeys("Divyaraj");
            //    //driver.FindElement(By.ClassName("mr-sm-2 form-control")).SendKeys("Divyaraj"); //--can not use compound class names use css selectors instead error//
            //    //driver.FindElement(By.ClassName("mr-sm-2 form-control")).SendKeys("abc@gmail.com");
            //    //driver.FindElement(By.ClassName("form-control")).SendKeys("Hello this is address textbox");
            //    //driver.FindElement(By.ClassName("form-control")).SendKeys("Hello this is permenant textbox");
            //    //driver.FindElement(By.ClassName("btn btn-primary")).Click();

            //    ///---Elements by selector---///
            //    //driver.FindElement(By.CssSelector("#userName")).SendKeys("Divyaraj");
            //    //driver.FindElement(By.CssSelector("#userEmail")).SendKeys("abc@gmail.com");
            //    //driver.FindElement(By.CssSelector("#currentAddress")).SendKeys("Hello this is address textbox");
            //    //driver.FindElement(By.CssSelector("#permanentAddress")).SendKeys("Hello this is permenant address box");
            //    //driver.FindElement(By.CssSelector("#submit")).Click();


            //    ///---Element by Xpath---///
            //    //driver.FindElement(By.XPath("//input[@id='userName']")).SendKeys("Divyaraj");
            //    //driver.FindElement(By.XPath("//input[@id='userEmail']")).SendKeys("abc@gmail.com");
            //    //driver.FindElement(By.XPath("//textarea[@id='currentAddress']")).SendKeys("Hello this is address textbox");
            //    //driver.FindElement(By.XPath("//*[@id='permanentAddress']")).SendKeys("Hello this is permenant address box");
            //    //driver.FindElement(By.XPath("//button[@id='submit']")).Click();

            //    ///Checkbox///
            //    //driver.Navigate().GoToUrl("https://demoqa.com/checkbox");
            //    //driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div/button[1]")).Click(); ///This is absoute Xpath and above all are relative Xpath
            //    //driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[1]/ol/li/ol/li[2]/span/label/span[1]")).Click();//selects document
            //    ////Thread.Sleep(2000);
            //    //driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[1]/ol/li/ol/li[2]/ol/li[1]/ol/li[1]/span/label/span[1]")).Click();//unselects react
            //    ////Thread.Sleep(2000);
            //    //driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[1]/ol/li/ol/li[2]/ol/li[2]/ol/li[2]/span/label/span[1]")).Click();//deselects private

            //    ///---Names were not availabe---///
            //    ///---error occurs always on click---///
            //    ///

            //    ///Radio Button///
            //    //driver.Navigate().GoToUrl("https://demoqa.com/radio-button");
            //    //driver.FindElement(By.CssSelector("#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div:nth-child(2) > div:nth-child(2) > label")).Click(); //Select Yes
            //    //Thread.Sleep(2000);
            //    //driver.FindElement(By.CssSelector("#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div:nth-child(2) > div:nth-child(3) > label")).Click(); //Select Impressive


            //    //Web Table//
            //    //driver.Navigate().GoToUrl("https://demoqa.com/webtables");
            //    //driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div[1]/div/div[7]/div/span[1]")).Click();
            //    //Thread.Sleep(2000);
            //    //driver.FindElement(By.Id("firstName")).Click();
            //    //driver.FindElement(By.Id("firstName")).SendKeys(Keys.Control + "a");
            //    //driver.FindElement(By.Id("firstName")).SendKeys(Keys.Delete);
            //    //driver.FindElement(By.Id("firstName")).SendKeys("Hello");
            //    //driver.FindElement(By.Id("submit")).Click();


            /// buttons
            Actions action = new Actions(driver);
        driver.Navigate().GoToUrl("https://demoqa.com/buttons");
        WebElement btndblclick = (WebElement)driver.FindElement(By.Id("doubleclickbtn"));
        action.DoubleClick(btndblclick).Perform();
        Thread.Sleep(2000);
        WebElement rgtclick = (WebElement)driver.FindElement(By.Id("rightclickbtn"));
        action.ContextClick(rgtclick).Perform();
        Thread.Sleep(2000);
        driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/button")).Click();
        Thread.Sleep(2000);


            //    /////Links///
            //    //Actions action = new Actions(driver);
            //    //driver.Navigate().GoToUrl("https://demoqa.com/links");
            //    //WebElement link1 = (WebElement)driver.FindElement(By)

        }
    }
}
