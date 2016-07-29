using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;

//using OpenQA.Selenium.IE;

namespace seleniumDemo
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driverFF;
        static IWebDriver driverGC;

        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
           driverFF = new EdgeDriver();
            //driverGC = new ChromeDriver(@"C:\chromedriver_win32");
            driverFF.Navigate().GoToUrl("http://www.google.com");
           //GoToUrl("http://www.hh.ru");
        }

        [TestMethod]
        public void TestFirefoxDriver()
        {
            driverFF.Navigate().GoToUrl("http://www.google.com");
            driverFF.FindElement(By.Id("lst-ib")).SendKeys("Selenium");
            driverFF.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
        }

        [TestMethod]
        public void TestChromeDriver()
        {
            //driverGC.Navigate().GoToUrl("http://www.google.com");
            //driverGC.FindElement(By.Id("lst-ib")).SendKeys("Selenium");
            //driverGC.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
        }

        //[AssemblyCleanup]
        //public static void TearDown()
        //{
        //    driver.Quit();
        //}
    }
}
