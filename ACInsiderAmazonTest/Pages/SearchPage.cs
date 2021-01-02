using ACAutoTestFramework.Base;
using ACAutoTestFramework.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;


namespace ACPTTTest.Pages
{
    class SearchPage:BasePage
    {
        string searchSamsung = "Samsung";

        [FindsBy(How = How.XPath, Using = "(//INPUT[@type='text'])[1]")]
        public IWebElement txtSearchBox { get; set; }

        [FindsBy(How = How.Id, Using = "/html/body/div[2]/div/div/div[2]/div/div/div[2]/div[2]/div[2]/div/div/div/form/div/button[2]")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[3]/div/div/div/div/div[2]/div[2]/a[1]/div/div[3]/span")]
        public IWebElement clickItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[3]/div/div/div[1]/div[3]/span/div[1]/div[2]/div[1]/div[1]/h1")]
        public IWebElement AproveSearchItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[2]/div/div/div[2]/div[1]/a/img")]
        public IWebElement clickHomePage { get; set; }
                                       
                                           
        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[3]/div/div/div/div/div[1]/h1/div/button")]
        public IWebElement cleanBasket { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[1]/div[2]/div[2]/button[2]")]
        public IWebElement removeProduct { get; set; }
                           
   
        public void Seach()
        {

            txtSearchBox.Click();
            //DriverContext.Driver.Wait();
            txtSearchBox.SendKeys(searchSamsung);
            txtSearchBox.Click();
            txtSearchBox.SendKeys(Keys.Enter);
            DriverContext.Driver.Wait();
    
            DriverContext.Driver.WaitForPageLoaded();

            clickItem.Click();
           

            //Aprove Contains Samsung
            string aproveItem = AproveSearchItem.Text;
           // Assert.IsTrue(aproveItem.Contains(searchSamsung));
            Console.WriteLine(aproveItem);

            clickHomePage.Click();
            DriverContext.Driver.Wait();
            DriverContext.Driver.WaitForPageLoaded();
           
            //DriverContext.Driver.Url = goBasket;
            //DriverContext.Driver.Wait();
            //cleanBasket.Click();
            //DriverContext.Driver.Wait();
            //removeProduct.Click();
            //DriverContext.Driver.Wait();
            //clickHomePage.Click();
            //DriverContext.Driver.Wait();
            //DriverContext.Driver.WaitForPageLoaded();

            txtSearchBox.Click();
            txtSearchBox.SendKeys(searchSamsung);
            txtSearchBox.Click();
            txtSearchBox.SendKeys(Keys.Enter);
            DriverContext.Driver.Wait();
            DriverContext.Driver.WaitForPageLoaded();
            clickItem.Click();
            DriverContext.Driver.Wait();

        }
    }
}
