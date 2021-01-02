using ACAutoTestFramework.Extensions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACAutoTestFramework.Base
{
   public abstract class TestInitializeHook
   {
        public readonly BrowserType Browser;

        public TestInitializeHook(BrowserType browser)
        {
            Browser = browser;
        }

        public void InitializeSttings()
        {
            //Open Browser
            OpenBrowser(Browser);
            DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Driver.Wait();
        }
        private void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        {
            switch (browserType)
            {
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
        }
       
        string url = "https://preprod.pttavm.com";
        string gmailurl = "https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
        public virtual void NavigateSite() 
        {
            DriverContext.Driver.Navigate().GoToUrl(url);
            DriverContext.Driver.Wait();
            Console.WriteLine("GoTo The URL");

        }

        public virtual void NavigateSiteGmail()
        {
            DriverContext.Driver.Navigate().GoToUrl(gmailurl);
            DriverContext.Driver.Wait();
            Console.WriteLine("Email ekranı açıldı.");

        }
   }
}
