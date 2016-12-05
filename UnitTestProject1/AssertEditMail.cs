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
    public class AssertEditMail : TestBase
    {
        [Test]
        public void CorrectChange() //если ввели валидные данные
        {
            Assert.IsTrue(man.Mail.AssertEmailCorrect()); //баг репорт
        }

        [Test]
        public void ErrorChange() //если ввели не валидные данные
        {
            Assert.IsTrue(man.Mail.AssertEmailError()); //баг репорт
        }

    }
}