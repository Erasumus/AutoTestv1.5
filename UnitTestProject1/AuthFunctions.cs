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
    public class AuthFunctions : CommonFunctions
    {
        public AuthFunctions(Manager manager) : base(manager)
        { }

        public void Login(Account user) //Вводим аккаунт.
        {
            driver.FindElement(By.LinkText("Вход")).Click();
            FillField("p_login", user.Login); 
            FillField("p_pass", user.Password); 
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }
        private void FillField(string field, string value) //Необходимые HTML field, в которые вводится значение аккаунта и пароля.
        {
            driver.FindElement(By.Name(field)).Clear(); 
            driver.FindElement(By.Name(field)).SendKeys(value); 
        }

        public void Exit() //Выход.
        {
            driver.FindElement(By.LinkText("Выход")).Click();
        }


        //ТЕСТОВАЯ ПОПЫТКА ДЛЯ ВХОДА 1(более детального решения)

        //public string ConditionAuth() //Проверка на заход
        //{
        //   string text = driver.FindElement(By.Name("выход")).FindElement(By.TagName("b")).Text; // Должен быть элемент с именем "выход", и имя HTML тега By.TagName
        //    return text.Substring(1, text.Length - 2); //извлекаем подстроку из строки, которая начинается с указанной позиции символа, и заканчивается перед концом строки.
        // }

        public bool IsLoggedIn()
        {
            return IsElementPresent(By.LinkText("Выход"));
        }

        ////ТЕСТОВАЯ ПОПЫТКА ДЛЯ ОШИБОЧНОГО 1(более детального решения)
        // public bool AuthError()
        //{
        //    return IsElementPresent(By.LinkText("Вход"));
        //}
        //ТАКЖЕ 
        //public bool ConditionAuthError
        //{
        //     if { textfield = ""; textfield = true;}
        //}

        public bool AuthError()
        {
            return IsElementPresent(By.LinkText("Вход"));
        }

    }
}
