using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAProgramRo.Pages
{
    public class HomePage
    {
        public void NavigateToTMPage(IWebDriver driver) 
        {
            // Create a time record
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationTab.Click();

            // Navigate to Time and Material page
            IWebElement timeAndMaterialPage = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterialPage.Click();


        }
    }
}
