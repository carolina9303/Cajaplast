using Cajaplast.Business;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cajaplast.TestCases
{
    class Carga_ArchivosTC
    {
        private IWebDriver driver = new ChromeDriver();
        #region Methods
        [Test, Order(0)]
        public void CargaArchivos()

        {
            LoginBC.Login(driver, "http://incursio-001-site1.itempurl.com/", "1dm3n", "1dm3n*");
            CargaArchivosBC.CargaArchivos(driver);

            



        }


        #endregion



    }
}
