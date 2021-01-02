using ACAutoTestFramework.Base;
using ACAutoTestFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;


namespace ACPTTTest.Pages
{
    class GMailLoginPage:BasePage
    {
        //object login page
        [FindsBy(How = How.Id, Using = "identifierId")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='identifierNext']/div/button")]
        public IWebElement identifierNext { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='password']")]
        public IWebElement txtPassword { get; set; }
       
        [FindsBy(How = How.XPath, Using = "//*[@id='passwordNext']/div/button")]
        public IWebElement passwordNext { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=':2f']")]
        public IWebElement clickFirstEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div/div[2]/div/div[1]/div/div[2]/div/table/tr/td[1]/div[2]/div[2]/div/div[3]/div/div/div/div/div/div[1]/div[2]/div[3]/div[3]/div/table/tbody/tr/td/table/tbody/tr[3]/td/div/table/tbody/tr[1]/td/table/tbody/tr/td/table/tbody/tr[3]/td/b")]
        public IWebElement extractCode { get; set; }

        public void GMailLogin()
        {
            string userName = "ptttestac@gmail.com";
            string password = "Ptttest123!";
        
            DriverContext.Driver.WaitForPageLoaded();
            txtUserName.Click();
            txtUserName.SendKeys(userName);
            DriverContext.Driver.Wait();
            identifierNext.Click();
            DriverContext.Driver.Wait();
            IWebElement passwordButton = DriverContext.Driver.FindElement(By.XPath("//input[@name='password']"));
            WebDriverWait wait = new WebDriverWait(DriverContext.Driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(passwordButton));

            txtPassword.Click();
            txtPassword.SendKeys(password);
            DriverContext.Driver.Wait();
            passwordNext.Click();
            Console.WriteLine("Kullanıcı girişi yapıldı");

            clickFirstEmail.Click();
            DriverContext.Driver.Wait();
            extractCode.Click();
            var pttCode = extractCode.Text;
            Console.WriteLine(pttCode);


        }
       
    }
}
