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
    public class NavigationFunctions : CommonFunctions
    {
        private string baseURL;
        public NavigationFunctions(Manager manager, string baseURL)
            : base(manager) //Навигация по сайту.
        {
            this.baseURL = baseURL;
        }

        public void OpenAboutMePage() //кликаем и открываем "Обо мне"
        {
            driver.FindElement(By.LinkText("Обо мне")).Click(); //не обязателен, но во избежании ошибок.
        }
        public void OpenForumPage() //кликаем и открываем "Форум"
        {
            driver.FindElement(By.LinkText("Форум")).Click(); //не обязателен, но во избежании ошибок.
        }

        public void OpenMyOfficePage() //кликаем и открываем "Мой кабинет"
        {
            driver.FindElement(By.LinkText("Мой кабинет")).Click();
        }
        public void OpenSite()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
        }

    }
}
