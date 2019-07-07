using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            if(hellohari.Text=="hello hari")
            {
                Console.WriteLine("Logged in successfully. Test has passed");
            }
            else
            {
                Console.WriteLine("Test has failed");
            }
            // Navigate to Times and material
            //Click on Administration menu
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            //click on Times and materials
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();

            //click on Create button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            //Select the value from Typecode dropdown
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            driver.FindElement(By.XPath(//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]")).Click();

            //Enter value for Code
            driver.FindElement(By.XPath();

            //Enter value Descrition
            driver.FindElement(By.Id("Description").SendKeys("autodescp"));

            //Enter Price per unit
            driver.FindElement(By.XPath("Price").SendKeys(4500);

            //Click on Save button
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            //Navigate to the last page

            //verify the existence of the record

        }
    }
}
