using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Selenium_UI_Web
{
    [TestFixture]
    public class DogApiTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://dogapi.dog/");
        }

        // This test now includes a proper assertion.
        [Test]
        public void ClickDemoLink()
        {
            var demoLink = driver.FindElement(By.LinkText("Demo"));
            demoLink.Click();
            Thread.Sleep(1000); // slow down for visibility

            Assert.AreEqual("https://dogapi.dog/demo", driver.Url);
            var breedInput = driver.FindElement(By.Id("breedId"));
            breedInput.SendKeys("f72528b5-a5d7-4a17-b709-aba2db722307");
            Thread.Sleep(1000); // slow down for visibility

            var getBreedButton = driver.FindElement(By.XPath("/html/body/main/div/div[2]/button"));
            getBreedButton.Click();
            Thread.Sleep(1000); // slow down for visibility

            var getclickURL = driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/a"));
            getclickURL.Click();
            Thread.Sleep(1000); // slow down for visibility

        }
        [Test]
        public void ClickDemoLinkerror()
        {
            var demoLink = driver.FindElement(By.LinkText("Demo"));
            demoLink.Click();

            System.Threading.Thread.Sleep(2000);
            Assert.AreEqual("https://dogapi.dog/demo", driver.Url);
            var breedInput = driver.FindElement(By.Id("breedId"));
            breedInput.SendKeys("haha");

            var getBreedButton = driver.FindElement(By.XPath("/html/body/main/div/div[2]/button"));
            getBreedButton.Click();

            var getclickURL = driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/a"));
            getclickURL.Click();

        }


        //[TearDown]
        //public void Teardown()
        //{
        //    // The driver should be closed after each test run.
        //    driver?.Quit();
        //}
    }
}