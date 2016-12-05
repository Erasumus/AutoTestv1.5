using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace MaslavyevAM
{
    public class Manager
    {
        public IWebDriver driver;
        public StringBuilder verificationErrors;
        public string baseURL;
        private AuthFunctions auth;
        private EditMailFunctions mail;
        private NavigationFunctions nav;
        private static ThreadLocal<Manager> man = new ThreadLocal<Manager>();


        public Manager()
        {
            driver = new ChromeDriver(@"C:\"); 
            //baseURL = "http://kpfu.ru/"; 
            baseURL = Settings.BaseUrl; //заменили на XML
            verificationErrors = new StringBuilder();
            driver.Manage().Window.Maximize(); //полный экран.
            auth = new AuthFunctions(this);
            mail = new EditMailFunctions(this);
            nav = new NavigationFunctions(this, baseURL);
        }

        public static Manager GetInstance() //Если Manager иницизировался уже, возвращается имеющий экземпляр.(некий Singleton)
        {
            if (!man.IsValueCreated)
            {
                Manager newInstance = new Manager();
                newInstance.Nav.OpenSite();
                man.Value = newInstance;
            }
            return man.Value; 
        }

        ~Manager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                
            }
        }


        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public AuthFunctions Auth
        {
            get
            {
                return auth;
            }
        }

        public EditMailFunctions Mail
        {
            get
            {
                return mail;
            }
        }

        public NavigationFunctions Nav
        {
            get
            {
                return nav;
            }
        }

        //public void Stop()
       // {
         //   driver.Quit();
        //}
    }
}
