using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using DedemanTests.PO;
using DedemanTests.PO_Silviu;
using OpenQA.Selenium.Interactions;
using DedemanTests.Enums;
using DedemanTests.Enums_Silviu;

namespace DedemanTests
{
    [TestClass]
    public class LoginTestDedeman_Silviu
    {

        private IWebDriver driver;
        private LoginPagePO loginPagePO;
        private Actions actions;
        private EnumsLogin enumsLogin;


        [TestInitialize]
        public void testInitialize() {
            driver = new ChromeDriver();
            loginPagePO = new LoginPagePO(driver);
            enumsLogin = new EnumsLogin();
            actions = new Actions(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.dedeman.ro/");
            Thread.Sleep(2000);
            actions.MoveToElement(driver.FindElement(By.CssSelector(enumsLogin.contulMeu))).Perform();
            driver.FindElement(By.CssSelector(enumsLogin.autentifica_te)).Click();
            loginPagePO.select_State_City("Vaslui", "Poienesti");
        }

        [TestCleanup]
        public void cleanup()
        {
            driver.Quit();
        }


        [TestMethod]
        public void login_Dedeman_with_corect_credentials() {
            Thread.Sleep(3000);
            loginPagePO.login("exosilviu@gmail.com", "test12345");
            Thread.Sleep(3000);
            actions = new Actions(driver);
            enumsLogin = new EnumsLogin();
            actions.MoveToElement(driver.FindElement(By.CssSelector(enumsLogin.contulMeu))).Perform();
            Thread.Sleep(3000);
           Assert.AreEqual("Silviu Silviu", loginPagePO.txtSuccessifullyLogin.Text);

        }

        [TestMethod]
        public void login_Dedeman_with_incorect_credentials()
        {
            Thread.Sleep(3000);
            loginPagePO.login("exosilviu1@gmail.com", "test123451");
            Thread.Sleep(3000);
            Assert.AreEqual("Adresa de e-mail sau parola incorecta. Te rugam să reincerci.", loginPagePO.txtFailLogin.Text);
        }

        [TestMethod]
        public void login_Dedeman_with_incorect_email()
        {
            Thread.Sleep(3000);
            loginPagePO.login("exosilviu1@gmail.com", "test12345");
            Thread.Sleep(3000);
            Assert.AreEqual("Adresa de e-mail sau parola incorecta. Te rugam să reincerci.", loginPagePO.txtFailLogin.Text);
        }

        [TestMethod]
        public void login_Dedeman_with_incorect_password()
        {
            Thread.Sleep(3000);
            loginPagePO.login("exosilviu@gmail.com", "test123451");
            Thread.Sleep(3000);
            Assert.AreEqual("Adresa de e-mail sau parola incorecta. Te rugam să reincerci.", loginPagePO.txtFailLogin.Text);
        }


    }
}
