using Cajaplast.Business;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cajaplast.TestCases
{
    class LoginTC
    {
        #region Variables
        private IWebDriver driver = new ChromeDriver();

        #endregion

       
        #region Methods

        [Test, Order(0)]
        public void Login()
        {
            LoginBC.Login(driver, "http://incursio-001-site1.itempurl.com/", "1dm3n", "1dm3n*");


        }

        #endregion

    }
}
