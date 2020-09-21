// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpTutorials.BaseClass;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {                        
            IWebElement usernameTextField = driver.FindElement(By.Id("txtUsername"));
            usernameTextField.SendKeys("Admin");            
        }

        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement usernameTextField = driver.FindElement(By.Id("txtUsername"));
            usernameTextField.SendKeys("Admin");
        }

        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement usernameTextField = driver.FindElement(By.Id("txtUsername"));
            usernameTextField.SendKeys("Admin");
            Thread.Sleep(5000);
        }
    }
}
