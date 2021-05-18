using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSpecFlowProject
{
    public class BaseClass:DriverHelper
    { 
     public static void ComboBox(string element, string value) { }
        IWebElement comboControl = Driver.FindElement(By.XPath($"//input[@id='{""}-awed'"));
       

    }
}
