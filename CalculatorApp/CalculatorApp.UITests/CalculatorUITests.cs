using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CalculatorUITests
{
    [TestFixture]
    public class CalculatorUITests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000"); // Replace with your calculator's URL
        }

        [Test]
        public void TestAddition()
        {
            driver.FindElement(By.Id("input1")).SendKeys("5");
            driver.FindElement(By.Id("input2")).SendKeys("3");
            driver.FindElement(By.Id("addButton")).Click();

            var result = driver.FindElement(By.Id("result")).Text;
            Assert.AreEqual("8", result);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
