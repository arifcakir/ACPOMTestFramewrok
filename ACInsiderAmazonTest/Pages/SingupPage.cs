using ACAutoTestFramework.Base;
using ACAutoTestFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;


namespace ACPTTTest.Pages
{
    class signupPage : BasePage
    {

        //object login page
        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[2]/div/div/div[2]/div[2]/div[3]/span")]
        public IWebElement IdAccountList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[1]/div/div/span/form/div/div[1]/span/div/label")]
        public IWebElement clickFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[1]/div/div/span/form/div/div[1]/span/div/input")]
        public IWebElement txtFirstName { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[1]/div/div/span/form/div/div[2]/span/div/label")]
        public IWebElement clickLastname { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[1]/div/div/span/form/div/div[2]/span/div/input")]
        public IWebElement txtLastname { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[1]/div/div/span/form/div/div[3]/span/div/label")]
        public IWebElement clickEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[1]/div/div/span/form/div/div[3]/span/div/input")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[1]/div/div/span/form/div/div[4]/div/span/div/label")]
        public IWebElement clickPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[1]/div/div/span/form/div/div[4]/div/span/div/input")]
        public IWebElement txtPassword { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='recaptcha-anchor']")]
        public IWebElement clickReCaptcha { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[3]/div[1]/div/div/span/div[1]")]
        public IWebElement clickCaptcha { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.recaptcha-checkbox-checkmark")]
        public IWebElement captcha { get; set; }



        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[1]/div/div/span/form/div/div[8]/button/div[1]/div")]
        public IWebElement btnSignup { get; set; }

        public void Signup()
        {
            string firstName = "Ptt";
            string lastName = "Demo";
            string email = "ptttestac@gmail.com";
            string password = "Ptttest123";
            string url = "https://preprod.pttavm.com/uye-ol";

            DriverContext.Driver.Url = url;
            clickFirstName.Click();
            txtFirstName.Click();
            txtFirstName.SendKeys(firstName);
            clickLastname.Click();
            txtLastname.Click();
            txtLastname.SendKeys(lastName);
            clickEmail.Click();
            txtEmail.Click();
            txtEmail.SendKeys(email);
            clickPassword.Click();
            txtPassword.Click();
            txtPassword.SendKeys(password);
            DriverContext.Driver.Wait();

            //TODO Test captchanın kaldırılması gerekir.
            //clickReCaptcha.Click();
            DriverContext.Driver.FindElement(By.XPath("//*[@id='main']/div[1]/div/div/div[2]/span")).Click();
            //clickCaptcha.Click();

            //IWebElement iframeSwitch = DriverContext.Driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div/div[2]/div/form/div/div/div/div/iframe"));
            //DriverContext.Driver.SwitchTo().Frame(iframeSwitch);
            //DriverContext.Driver.FindElement(By.CssSelector("div[class=recaptcha-checkbox-checkmark]")).Click();

            //DriverContext.Driver.SwitchTo().Frame(DriverContext.Driver.FindElement(By.CssSelector("iframe[src*='recaptcha']")));
            ////clickReCaptcha.Click();
            //clickCaptcha.Click();
            //DriverContext.Driver.Wait();

            //clickReCaptcha.Click();
            //clickCaptcha.Click();
            //captcha.Click();

            //ReCaptcha_click re = new ReCaptcha_click();   
            //

            btnSignup.Click();
            Console.WriteLine("Kullanıcı kaydı yapıldı");
           

        }

    public void ClickLoginId()
    {
        IdAccountList.Click();
    }

    public class ReCaptcha_click
    {

       public static void main(String[] args)
       {

                //System.setProperty("webdriver.chrome.driver", "C:\\Utility\\BrowserDrivers\\chromedriver.exe");
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("start-maximized");
                options.AddArguments("disable-infobars");
                options.AddArguments("--disable-extensions");
                IWebDriver driver = new ChromeDriver(options);
                driver.Url = ("https://rsps100.com/vote/760");
                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.XPath("//*[@id='main']/div[1]/div/div/span/form/div/div[6]/div/div/div/iframe")));
                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div.recaptcha-checkbox-checkmark"))).Click();
       }

    }

    }
}
