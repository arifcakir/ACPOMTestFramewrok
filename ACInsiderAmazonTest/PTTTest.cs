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
    public class PTTTest:HookInitialize
    {
     
        [TestMethod]
        public void PTTSearchAddtoBasketAndPay()
        {
            LoginPage page = new LoginPage();

            page.ClickLoginId();
            page.Login();

            SearchPage spage = new SearchPage();
            spage.Seach();

            BasketAddandPayPage bpage = new BasketAddandPayPage();
            bpage.BasketAddPay();

        }

        [TestCleanup]
        public void TestClose()
        {
            DriverContext.Driver.Close();
            DriverContext.Driver.Quit();
        }

    }
}
