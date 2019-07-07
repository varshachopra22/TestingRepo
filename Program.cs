using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //open or launch chrome browser
            IWebDriver driver = new ChromeDriver();

            // launch turnup portal
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2fTimeMaterial");
            driver.Manage().Window.Maximize();

            //Enter username
            IWebElement Username = driver.FindElement(By.Id("UserName"));
            Username.SendKeys("hari");

            //Enter password
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("123123");

            //Clickn on the login button
            IWebElement Logon = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            Logon.Click();

            //validate if user has logged in successfully
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (hellohari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully. Test has passed");
            }
            else
            {
                Console.WriteLine("Test has failed");
            }
            //Navigate to Times and material
            //Click on Administration menu
            IWebElement Adm = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Adm.Click();

            //click on Times and materials
            IWebElement TimeMate = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeMate.Click();

            //click on Create button
            IWebElement Createbut = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            Createbut.Click();

            //Select the value from Typecode dropdown
            IWebElement TypeCode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            TypeCode.Click();

            //Enter value for Code
            IWebElement CodeTxt = driver.FindElement(By.XPath("//*[@id='Code']"));
            CodeTxt.SendKeys("AutoCode");

            //Enter value Descrition
            IWebElement Desc = driver.FindElement(By.Id("Description"));
            Desc.SendKeys("autodescp");

            //Enter Price per unit
            //IWebElement Priceextbox = driver.FindElement(By.Id("Price"));
            //Priceextbox.SendKeys(String.valueOf(4500));

            //Click on Save button
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
            Thread.Sleep(1000);

            //Navigate to the last page
            IWebElement lastpg = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[1]"));
            lastpg.Click();

            //verify the existence of the record
            IWebElement NewRec = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[1]"));
            if(NewRec.Text == "Autocode")
            {
                Console.WriteLine("Record successfully created");
            }
            else
            {
                Console.WriteLine("Record not created");
            }
        }
    }
}
