using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumSpecFlowProject
{
    public class Tests : DriverHelper
    {
   
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Set Up");
            //System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\\Drivers\\chromedriver_win32\\chromedriver.exe");
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("disable-infobars");
            options.AddArguments("--disable-extensions");
            Driver = new ChromeDriver(@"C:\Drivers\chromedriver_win32", options);
        }
         
        [Test]
        public void Test1()
        {
           
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Vibha");
            
 
            Assert.Pass();
        }
    }
}