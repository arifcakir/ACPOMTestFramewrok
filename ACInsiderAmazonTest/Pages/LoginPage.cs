using ACAutoTestFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;


namespace ACPTTTest.Pages
{
    class LoginPage:BasePage
    {
        //object login page
        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[2]/div/div/div[2]/div[2]/div[3]/span")]
        public IWebElement IdAccountList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[6]/div[2]/div/span/form/div[1]/div/span/div/label")]
        public IWebElement clickUserName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[6]/div[2]/div/span/form/div[1]/div/span/div/input")]
        public IWebElement txtUserName { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[6]/div[2]/div/span/form/div[2]/div/span/div/label")]
        public IWebElement clickPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[6]/div[2]/div/span/form/div[2]/div/span/div/input")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[6]/div[2]/div/span/form/div[4]/button")]
        public IWebElement btnLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[6]/div[1]/button")]
        public IWebElement closeModal { get; set; }

        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        public IWebElement txtSearchBox { get; set; }

        [FindsBy(How = How.Id, Using = "nav-search-submit-text")]
        public IWebElement txtSearchButton { get; set; }

        public void Login()
        {
            string userName = "ptttestac@gmail.com";
            string password = "Ptttest123";

            clickUserName.Click();
            txtUserName.Click();
            txtUserName.SendKeys(userName);
            clickPassword.Click();
            txtPassword.Click();
            txtPassword.SendKeys(password);
            btnLogin.Submit();
            Console.WriteLine("Kullanıcı girişi yapıldı");
            closeModal.Click();

        }

        public void ClickLoginId()
        {
            IdAccountList.Click();
        }

        public SearchPage ClickSearchButton()
        {
            txtSearchButton.Click();
            return new SearchPage();
        }

    }
}
