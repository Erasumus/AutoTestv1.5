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
    public class TestBase
    {

        protected Manager man;

        [SetUp]
        public void SetupTest()
        {
            man.driver.Manage().Window.Maximize(); //полный экран.
            man = Manager.GetInstance();
            man.Nav.OpenSite();
            man = new Manager();
        }

        //[TearDown] 
        //public void TeardownTest()
       // {

         //   man.Stop();
        //}

    }
}


