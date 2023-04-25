using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstAzureAppTestProject
{
    [TestClass()]
    public class SeleniumTestOfGoogleSearch
    {
        [TestMethod]
        public void Test_Search_Riphah_International_University()
        {
            int waitingTime = 2000;
            By googleSearchBar = By.Name("q");
            By googleSearchButton = By.Name("btnK");

            IWebDriver webDriver = new ChromeDriver();

            Thread.Sleep(waitingTime);

            webDriver.Navigate().GoToUrl("https://www.google.com.pk");

            Thread.Sleep(waitingTime);

            webDriver.Manage().Window.Maximize();

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchBar).SendKeys("Riphah International University");

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchButton).Click();

            webDriver.Quit();
        }
        [TestMethod]
        public void Test_Search_Riphah_International_University_IsDisplayed()
        {
            string searchText = "riphah university";
            string displayResult = "Riphah International University";
            int waitingTime = 2000;
            By googleSearchBar = By.Name("q");
            By googleSearchButton = By.Name("btnK");
            By googleResultText = By.XPath(".//h2//span[text()='"+ displayResult + "']");

            IWebDriver webDriver = new ChromeDriver();

            Thread.Sleep(waitingTime);

            webDriver.Navigate().GoToUrl("https://www.google.com.pk");

            Thread.Sleep(waitingTime);

            webDriver.Manage().Window.Maximize();

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchBar).SendKeys(searchText);

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchButton).Click();

            Thread.Sleep(waitingTime);

            var actualResultText = webDriver.FindElement(googleResultText);

            Assert.IsTrue(actualResultText.Text.Equals(displayResult));

            webDriver.Quit();
        }
        //[TestMethod]
        //public void Test_Value_Check()
        //{
        //    string searchText = "Selenium Test";
        //    string displayResult = "Riphah International University";
        //    int waitingTime = 2000;
        //    By textField = By.Name("inp");
        //    By checkButton = By.Name("chk");


        //    IWebDriver webDriver = new ChromeDriver();

        //    Thread.Sleep(waitingTime);

        //    webDriver.Navigate().GoToUrl("https://localhost:7007/");

        //    Thread.Sleep(waitingTime);

        //    webDriver.Manage().Window.Maximize();

        //    Thread.Sleep(waitingTime);

        //    webDriver.FindElement(textField).SendKeys(searchText);

        //    Thread.Sleep(waitingTime);

        //    webDriver.FindElement(checkButton).Click();

        //    Thread.Sleep(waitingTime);

        //    By outputField = By.Id("txtOutput");

        //    var actualResultText = webDriver.FindElement(outputField);

        //    Assert.IsTrue(actualResultText.Text.Equals(displayResult));

        //    webDriver.Quit();
        //}
    }
}
