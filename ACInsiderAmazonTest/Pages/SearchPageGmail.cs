using ACAutoTestFramework.Base;
using ACAutoTestFramework.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;


namespace ACPTTTest.Pages
{
    class SearchPageGmail:BasePage
    {
        string searchsamsung = "Samsung";

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[2]/div/div/div[2]/div[2]/div[2]/div/div/div/form/input")]
        public IWebElement txtSearchBox { get; set; }

        [FindsBy(How = How.Id, Using = "//*[@id='main']/div[2]/div/div/div[2]/div[2]/div[2]/div/div/div/form/div/button[2]/i")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[3]/div/div/div/div/div[2]/div[2]/a[1]/div/div[1]/div")]
        public IWebElement clickItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[3]/div/div/div[1]/div[3]/span/div[1]/div[2]/div[1]/div[1]/h1")]
        public IWebElement AproveSearchItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[2]/div/div/div[2]/div[1]/a/img")]
        public IWebElement clickHomePage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[3]/div/div/div[1]/div[3]/span/div[1]/div[2]/div[2]/div[2]/button[1]/div[2]")]
        public IWebElement addBasketItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='search']/div[1]/div[2]/div/span[8]/div/div/span/div/div/ul/li[3]/a")]
        public IWebElement xPathClickPage2 { get; set; }

        
        public void Seach()
        {
            txtSearchBox.Click();
            DriverContext.Driver.Wait();
            txtSearchBox.SendKeys(searchsamsung);
            SearchButton.Click();
            DriverContext.Driver.Wait();
            DriverContext.Driver.WaitForPageLoaded();

            clickItem.Click();
           

            //Aprove Contains Samsung
            string aproveItem = AproveSearchItem.Text;
            Assert.IsTrue(aproveItem.Contains(searchsamsung));
            Console.WriteLine(aproveItem);

            clickHomePage.Click();

            txtSearchBox.Click();
            txtSearchBox.SendKeys(searchsamsung);
            SearchButton.Submit();
            DriverContext.Driver.Wait();
            DriverContext.Driver.WaitForPageLoaded();
         

            //Item add basket
            addBasketItem.Click();
            DriverContext.Driver.Wait();

 
        }

    }
}
