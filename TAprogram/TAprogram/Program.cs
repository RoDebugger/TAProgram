using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

internal class Program
{
    private static void Main(string[] args)
    {
        // Open Chrome Browser
        IWebDriver driver = new ChromeDriver();

        // Launch TurnUp Portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
        driver.Manage().Window.Maximize();
        Thread.Sleep(1000);

        // Identify username textbox and enter valid username
        IWebElement userNametextbox = driver.FindElement(By.Id("UserName"));
        userNametextbox.SendKeys("hari");

        // Identify password textbox and enter valid password
        IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        passwordTextbox.SendKeys("123123");

        // Identify login button and click on it
        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginButton.Click();
        Thread.Sleep(2000);

        // Check if user has logged in successfully
        IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));


        if (helloHari.Text == "Hello hari!")
        {
            ;
            Console.WriteLine("user has logged in successfully.Test Passed!");
        }
        else
        {
            Console.WriteLine("user has not logged in.Test Failed!");
        }

        // Create a Time record
        IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        administrationTab.Click();

        // Navigate to time and material page
        IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]"));
        timeAndMaterialOption.Click();

        // Click on create new button
        IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        createNewButton.Click();

        // Select Time from dropdown
        IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
        typeCodeDropdown.Click();

        IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
        timeOption.Click();

        // Type code into code textbox
        IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
        codeTextbox.SendKeys("TAprogram");

        // Type description into description textbox
        IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
        descriptionTextBox.SendKeys("This is a description");

        // Type price into price textbox
        IWebElement tagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        tagOverlap.Click();

        IWebElement priceTextBox = driver.FindElement(By.Id("Price"));
        priceTextBox.SendKeys("12");

        // Click on save button
        IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        saveButton.Click();
        Thread.Sleep(3000);

        // Check if time record has been created successfully
        IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        goToLastPageButton.Click();

        IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

        if (newCode.Text == "TAprogram")
        {
            Console.WriteLine("Time record created successfully!");
        }

        else
        {
            Console.WriteLine("Time record has not been created!");
        }







    }
}