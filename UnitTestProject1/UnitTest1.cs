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
    public class UnitTest1 : TestBase
    {

        [Test]
        public void TheUntitledTest()
        {
            man.Nav.OpenSite();
            Account userdata = new Account(Settings.Email, Settings.Password);
            man.Auth.Login(userdata);
            man.Nav.OpenForumPage();
            man.Nav.OpenAboutMePage();
            man.Mail.EditEmail();
            man.Nav.OpenMyOfficePage();
            man.Auth.Exit();
        }
    }


}