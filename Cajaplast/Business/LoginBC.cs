using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Cajaplast.Business
{
    public static class LoginBC
    {

        #region Methods

        public static void Login(IWebDriver driver, string urlServidor, string user, string password)
        {
            driver.Navigate().GoToUrl(urlServidor);
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement menu = driver.FindElement(By.ClassName("header-menu-toggle"));
            menu.Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("[href*='/IniciarSesion/Entrar']")).Click();
            IWebElement usuario = driver.FindElement(By.Id("usuario"));
            usuario.SendKeys(user);
            IWebElement contrasena = driver.FindElement(By.Id("contrasena"));
            contrasena.SendKeys(password);
            IWebElement btnIngresar = driver.FindElement(By.XPath("//input[@value='Ingresar']"));
            btnIngresar.Click();
            Thread.Sleep(4000);


        }
        #endregion




    }
}
