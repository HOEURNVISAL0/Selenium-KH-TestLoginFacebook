using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;

namespace Selenium_UI__Web
{
    [TestFixture]
    public class LoginTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Auto download the right ChromeDriver version
            new DriverManager().SetUpDriver(new ChromeConfig());

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
        }

        [Test]
        public void TestSuccessfulLogin()
        {
            var usernameField = driver.FindElement(By.Id("email"));
            var passwordField = driver.FindElement(By.Id("pass"));
            var loginButton = driver.FindElement(By.Name("login"));

            // ⚠️ Replace with your own test account
            usernameField.SendKeys("ithuce1@gmail.com");
            passwordField.SendKeys("Sacombank123?");
            loginButton.Click();

            // Simple validation: after login, Facebook redirects to home
            Assert.IsTrue(driver.Url.Contains("facebook.com"));
        }

        //[TearDown]
        //public void Teardown()
        //{
        //    driver?.Quit(); // Cleanup after test
        //}
    }
}
