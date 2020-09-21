﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTutorials.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
