using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Threading;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace LiveExercise
{
    [TestClass]
    public class SeleniumTestCommand
    {
       [DataTestMethod]
        [DataRow("CH","https://www.demoqa.com")]

        public void TestMethod(string browser,string url)
        { 
          IWebDriver driver;
        
          if(browser == "FF")
          {
          driver = new FirefoxDriver(@"C:\Root Folder\WebDriver");
          
          } else
          { 
            driver = new ChromeDriver(@"C:\Root Folder\WebDriver");
          
          }
            driver.Navigate().GoToUrl(url);
    
            IWebElement num= driver.FindElement(By.XPath("//input[@id='userNumber']"));
            string expectednum = num.GetAttribute("placeholder");
            string actualnum = "Mobile Number";
            Assert.AreEqual(expectednum,actualnum,"num is not matched");
            Thread.Sleep(3000);
            IList<IWebElement> links = driver.FindElements(By.TagName("a"));
            int expcountoflinks = links.Count;
            int actuallinks = 38;
             Assert.AreEqual(expectednum,actualnum,"num is not matched");
            driver.Quit();
        }
    }
}

