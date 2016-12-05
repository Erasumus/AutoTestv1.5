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
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWthValidData() //если ввели валидные данные
        {
            Account user = new Account(Settings.Email, Settings.Password) { Login = "", Password = "" }; //необходимо имя метода
            man.Auth.Login(user);
            Assert.IsTrue(man.Auth.IsLoggedIn()); //баг репорт
        }
        [Test]
        public void LoginWithInvalidData() //если ввели не валидные данные
        {
            Account user = new Account(IncorrectXML.Email, IncorrectXML.Password) { Login = "", Password = "" }; //необходимо имя метода
            man.Auth.Login(user);
            Assert.IsTrue(man.Auth.AuthError()); //баг репорт
        }
    }
}
