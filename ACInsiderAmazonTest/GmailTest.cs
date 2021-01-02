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
    public class GmailTest:HookInitializeGmail
    {
               
        [TestMethod]
        public void GmailExportCode()
        {
            GMailLoginPage page = new GMailLoginPage();
                       
            page.GMailLogin();

        }

        [TestCleanup]
        public void TestClose()
        {
            DriverContext.Driver.Close();
            DriverContext.Driver.Quit();
        }

    }
}
