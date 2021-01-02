using ACAutoTestFramework.Base;
using ACAutoTestFramework.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace ACPTTTest.Pages
{
    class BasketAddandPayPage : BasePage
    {
        string goBasket = "https://preprod.pttavm.com/my/tr/sepet";
        string cardName = "Demo Card";
        string cardNumber = "4943141483711580";
        string cardDate = "07/21";
        string cvc = "576";
        string ordermessage = "Siparişiniz tamamlandı.";

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[3]/div/div/div[1]/div[3]/span/div[1]/div[2]/div[2]/div[2]/button[1]")]
        public IWebElement addBasketItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[3]/div/div/div/div/div[2]/div[2]/button/div[2]")]
        public IWebElement checkProduct { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[2]/div/div/div/span/div/div[2]/button/div[2]")]
        public IWebElement goPay { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='payment-form']/div[2]/div[1]/input")]
        public IWebElement txtCardName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='payment-form']/div[2]/div[2]/input")]
        public IWebElement txtCardNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='payment-form']/div[2]/div[4]/div[1]/input")]
        public IWebElement txtExpireDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='payment-form']/div[2]/div[4]/div[2]/input")]
        public IWebElement txtCVC { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='home']/main/div[1]/div/div[2]/form/div[4]/div[8]")]
        public IWebElement agreementInput { get; set; }

        [FindsBy(How = How.Id, Using = "checkout-credit-card")]
        public IWebElement checkoutCard { get; set; }

        [FindsBy(How = How.Id, Using = "//*[@id='main']/div[3]/div/div/div/div[3]/h1")]
        public IWebElement checkOrder { get; set; }


        [FindsBy(How = How.Id, Using = "//*[@id='main']/div[3]/div/div/div/div[3]/h1/text()")]
        public IWebElement txtcheckOrder { get; set; }

        public void BasketAddPay()
        {
            //Item add basket
            addBasketItem.Click();
            DriverContext.Driver.Wait();
            DriverContext.Driver.WaitForPageLoaded();
            DriverContext.Driver.Url = goBasket;
            DriverContext.Driver.Wait();

            checkProduct.Click();
            DriverContext.Driver.Wait();

            goPay.Click();
            DriverContext.Driver.Wait();

            txtCardName.Click();
            txtCardName.SendKeys(cardName);
            txtCardNumber.Click();
            txtCardNumber.SendKeys(cardNumber);
            DriverContext.Driver.Wait();


            txtExpireDate.Click();
            txtExpireDate.SendKeys(cardDate);
            DriverContext.Driver.Wait();
            txtCVC.Click();
            txtCVC.SendKeys(cvc);
            DriverContext.Driver.Wait();

            agreementInput.Click();
            DriverContext.Driver.Wait();
         
            WebDriverWait wait = new WebDriverWait(DriverContext.Driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(checkoutCard));
            checkoutCard.Click();
            DriverContext.Driver.Wait();

            //Check Order
            //var ordercheck = txtcheckOrder.Text;
            //Assert.IsTrue(ordercheck.Contains(ordermessage));
            //Console.WriteLine(ordercheck);
            //DriverContext.Driver.Wait();

        }

    }
}
