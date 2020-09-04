using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Cajaplast.Business
{
    class CargaArchivosBC
    {

        #region Methods


        public static void CargaArchivos(IWebDriver driver)
        {


            driver.Navigate().GoToUrl("http://incursio-001-site1.itempurl.com/Soporte/CargaSoporte");

            for (int i = 0; i <= 1100; i++)
            {
                Thread.Sleep(1600);
                //Cliente
                IWebElement cliente = driver.FindElement(By.Id("CodigoCli"));
                SelectElement opCliente = new SelectElement(cliente);
                Thread.Sleep(500);
                opCliente.SelectByValue("3");

                //Tipo soporte
                IWebElement tipoSoporte = driver.FindElement(By.Id("CodigoSopP"));
                SelectElement opTipoSoporte = new SelectElement(tipoSoporte);
                Thread.Sleep(500);
                opTipoSoporte.SelectByValue("1");

                //Carga de documento
                IWebElement documentoSoporte = driver.FindElement(By.Id("Documento"));
                documentoSoporte.SendKeys("C:\\Users\\yasuarez\\Desktop\\prueba.pdf");
                //Boton guardar

                IWebElement btnGuardarArchivo = driver.FindElement(By.XPath("//a[@href='#finish']"));
                btnGuardarArchivo.Click();

                Thread.Sleep(3500);
                Thread.Sleep(1500);
            }




        }


    }



    #endregion
}
