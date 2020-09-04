using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Cajaplast.Business
{
    public static class CrearUsuarioBC
    {
        #region Methods

        public static void CrearUsuario(IWebDriver driver)
        {

            IWebElement btnVerUsuario = driver.FindElement(By.XPath("//a[@href='/Usuario/Administracion']"));
            btnVerUsuario.Click();
            IWebElement btnCrearUsuario = driver.FindElement(By.XPath("//a[@href='../../Usuario/CrearModificar']"));
            btnCrearUsuario.Click();

            //Estado
            IWebElement estadoUsuario = driver.FindElement(By.Id("CodigoEst"));
            SelectElement opEstadoUsuario = new SelectElement(estadoUsuario);
            Thread.Sleep(500);
            opEstadoUsuario.SelectByValue("1");
            Thread.Sleep(500);
            //Tipo Documento
            IWebElement tipoDocumento = driver.FindElement(By.Id("CodigoTid"));
            SelectElement opTipoDocumento = new SelectElement(tipoDocumento);
            Thread.Sleep(500);
            opTipoDocumento.SelectByValue("1");
            Thread.Sleep(500);
            //No. Documento
            IWebElement noDocumento = driver.FindElement(By.Id("Identificacion"));
            noDocumento.SendKeys("79489520");
            //Primer Nombre
            IWebElement primerNombre = driver.FindElement(By.Id("PrimerNombre"));
            primerNombre.SendKeys("Victor");
            //Segundo Nombre
            IWebElement segundoNombre = driver.FindElement(By.Id("SegundoNombre"));
            segundoNombre.SendKeys("Andres");
            //Primer Apellidp
            IWebElement primerApellido = driver.FindElement(By.Id("PrimerApellido"));
            primerApellido.SendKeys("Gonzalez");
            //Segundo Apellido
            IWebElement segundoApellido = driver.FindElement(By.Id("SegundoApellido"));
            segundoApellido.SendKeys("Pombo");
            //Correo Electronico 
            IWebElement correoElectronico = driver.FindElement(By.Id("CorreoElectronico"));
            correoElectronico.SendKeys("victor@gmail.com");
            //Usuario 
            IWebElement usuario = driver.FindElement(By.Id("Usuario"));
            usuario.SendKeys("victor.gonzalez");
            Thread.Sleep(500);
            //Contrasena
            IWebElement contrasena = driver.FindElement(By.Id("Contrasena"));
            contrasena.SendKeys("Colombia2020*");
            //Contrasena
            IWebElement confirContrasena = driver.FindElement(By.Id("ContrasenaNueva"));
            confirContrasena.SendKeys("Colombia2020*");
            //Perfil usuario
            IWebElement perfilUsuario = driver.FindElement(By.Id("TUsuarioPerfil"));
            SelectElement opPerfilUsuario = new SelectElement(perfilUsuario);
            Thread.Sleep(500);
            opPerfilUsuario.SelectByValue("3");
            Thread.Sleep(500);
            IWebElement btnSiguienteCrearUsuario = driver.FindElement(By.XPath("//a[@href='#next']"));
            btnSiguienteCrearUsuario.Click();
            Thread.Sleep(500);
            //Asignar áreas 
            IWebElement btnAsignarAreas = driver.FindElement(By.XPath("//button[@onclick='HabilitarArea()']"));
            btnAsignarAreas.Click();
            //cliente
            IWebElement clienteArea = driver.FindElement(By.Id("CodigoCli"));
            SelectElement opClienteArea = new SelectElement(clienteArea);
            Thread.Sleep(500);
            opClienteArea.SelectByValue("1");

            //sucursal 
            IWebElement sucursalArea = driver.FindElement(By.Id("CodigoSuc"));
            SelectElement opSucursalArea = new SelectElement(sucursalArea);
            Thread.Sleep(500);
            opSucursalArea.SelectByValue("1");
            Thread.Sleep(500);

            //área

            try
            {
                SelectElement opAreaUsuario = new SelectElement(driver.FindElement(By.Id("TUsuarioArea")));
                System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> opAreaUsuario2 = driver.FindElements(By.Id("TUsuarioArea"));
                var opAreaUsuario3 = new SelectElement((IWebElement)opAreaUsuario2);
                var opAreaUsuario4 = new SelectElement(driver.FindElement(By.Name("TUsuarioArea")));


                opSucursalArea.SelectByIndex(1);
                opAreaUsuario3.SelectByIndex(1);
                opAreaUsuario4.SelectByIndex(1);
            }
            catch (Exception ex)
            {

            }
        



            //Boton Guardar área
            IWebElement btnGuardarArea = driver.FindElement(By.XPath("//button[@onclick='GuardarArea()']"));
            btnGuardarArea.Click();

            //Boton Guardar usuario 
            IWebElement btnGuardarUsuario = driver.FindElement(By.XPath("//a[@href='#finish']"));
            btnGuardarUsuario.Click();


        }



        #endregion
    }
}
