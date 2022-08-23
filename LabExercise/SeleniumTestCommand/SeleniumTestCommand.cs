using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace LabExercise
{
    [TestClass]
    public class SeleniumTestCommand
    {
        [TestMethod]
        public void TestMethod1()
        {
            WebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            Driver.Manage().Window.Maximize();
            IList<IWebElement> btns = Driver.FindElements(By.TagName("button"));
            int expbtns = btns.Count;
            int actualbtns = 2;
            Assert.AreEqual(expbtns,actualbtns,"num is not matched");
            Driver.Quit();
        }
           
           
           [TestMethod]
           public void TestMethod2()
        {
            WebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement email = Driver.FindElement(By.XPath("//input[@id='userEmail']"));
            string expectedemail = email.GetAttribute("placeholder");
            string actualemail ="name@example.com";
            Assert.AreEqual(expectedemail,actualemail,"email is not matched");
            Thread.Sleep(3000);

            Driver.Quit();
        }


            /*[TestMethod]
            public void TestMethod3()

        {
            WebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://automationpractice.com/index.php");
            Driver.Manage().Window.Maximize();
            IWebElement Contact = Driver.FindElement(By.PartialLinkText("contact"));
            Contact.Click();
            Thread.Sleep(3000);
            IWebElement subject = driver.FindElement(By.XPath("//select[@id='id_contact']"));
            Thread.Sleep(3000);
            SelectElement st = new SelectElement(Driver.FindElement(By.Id("id_contact")));
            st.SelectByText("Customer Service");
            Thread.Sleep(3000);
            Driver.Quit();
         }*/
            

        
            

            
            
                
    
    }
}

