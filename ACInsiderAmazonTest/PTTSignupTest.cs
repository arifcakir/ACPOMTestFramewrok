using System;
using ACAutoTestFramework.Base;
using ACPTTTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace ACPTTTest
{
    [TestClass]
    public class PTTSignupTest:HookInitialize
    {
               
        [TestMethod]
        public void PTTSignup()
        {
            signupPage page = new signupPage();

            page.Signup();


        }

        [TestCleanup]
        public void TestClose()
        {
            DriverContext.Driver.Close();
            DriverContext.Driver.Quit();
        }

    }
}
