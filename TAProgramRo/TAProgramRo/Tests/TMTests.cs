using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAProgramRo.Pages;
using TAProgramRo.Utilities;

namespace TAProgramRo.Tests
{
    [TestFixture]
    public class TMTests : CommonDriver
    {
        [SetUp]
        public void SetUpSteps()
        {
            // Open chrome browser
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObject = new LoginPage();
            loginPageObject.LoginActions(driver);

            // Home page object initialization and definition 
            HomePage homePageObject = new HomePage();
            homePageObject.NavigateToTMPage(driver);

        }
        [Test]
        public void CreateTimeRecord()
        {

            // TM page object initialization and definition 
            TMPage tMPage = new TMPage();
            tMPage.CreateTimeRecord(driver);

        }
        [Test]
        public void EditTimeRecord()
        {
            // Edit a time record
            TMPage tMPage = new TMPage();
            tMPage.EditTimeRecord(driver);

        }
        [Test]
        public void DeleteTimeRecord() 
        {
            // Delete a time record
            TMPage tMPage = new TMPage();
            tMPage.DeleteTimeRecord(driver);

        }
        [TearDown]
        public void CloseTestRun() 
        {
            driver.Quit();
        }
    }
}
