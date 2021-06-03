using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Interactions;
using DedemanTests.Enums_Vlad;
using DedemanTests.PO_Vlad;

namespace DedemanTests
{
    [TestClass]
    public class OpinieTest_Vlad
    {
        private IWebDriver driver;
        private OpiniePO opiniePO;
        private Actions actions;
        private EnumsOpinie enumsOpinie;

        [TestInitialize]
        public void testInitialize()
        {
            driver = new ChromeDriver();
            opiniePO = new OpiniePO(driver);
            enumsOpinie = new EnumsOpinie();
            actions = new Actions(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.dedeman.ro/");
            Thread.Sleep(2000);
            actions.MoveToElement(driver.FindElement(By.CssSelector(enumsOpinie.contulMeu))).Perform();
            driver.FindElement(By.CssSelector(enumsOpinie.autentifica_te)).Click();
            opiniePO.select_State_City("Vaslui", "Poienesti");

            Thread.Sleep(3000);
            opiniePO.login("exosilviu@gmail.com", "test12345");
            Thread.Sleep(3000);
            actions = new Actions(driver);
            enumsOpinie = new EnumsOpinie();
            actions.MoveToElement(driver.FindElement(By.CssSelector(enumsOpinie.contulMeu))).Perform();
            Thread.Sleep(3000);

            opiniePO = new OpiniePO(driver);
            opiniePO.searchProducts("birou mobil");
            driver.FindElement(By.XPath(enumsOpinie.opinie)).Click();
            Thread.Sleep(3000);
        }

        [TestCleanup]
        public void cleanup()
        {
            driver.Quit();
        }

        [TestMethod]
        public void opinieProdus_corect()
        {
            opiniePO.completeaza_date("Excelent", "Un produs de nota 10");
            driver.FindElement(By.XPath(enumsOpinie.nota)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(enumsOpinie.acord)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(enumsOpinie.trimite)).Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Opinia a fost inregistrata cu succes!", opiniePO.txtReusita.Text);
        }

        [TestMethod]
        public void opinieProdus_gresitNume()
        {
            opiniePO.completeaza_date("", "Un produs de nota 10");
            driver.FindElement(By.XPath(enumsOpinie.nota)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(enumsOpinie.acord)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(enumsOpinie.trimite)).Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Acest camp este obligatoriu.", opiniePO.txtEroare.Text);
        }

        [TestMethod]
        public void opinieProdus_gresitNota()
        {
            opiniePO.completeaza_date("Excelent", "Un produs de nota 10");
            driver.FindElement(By.XPath(enumsOpinie.acord)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(enumsOpinie.trimite)).Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Acest camp este obligatoriu.", opiniePO.txtEroare2.Text);
        }

        [TestMethod]
        public void opinieProdus_gresitMesaj()
        {
            opiniePO.completeaza_date("Excelent", "");
            driver.FindElement(By.XPath(enumsOpinie.nota)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(enumsOpinie.acord)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(enumsOpinie.trimite)).Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Acest camp este obligatoriu.", opiniePO.txtEroare3.Text);
        }

        [TestMethod]
        public void opinieProdus_gresitAcord()
        {
            opiniePO.completeaza_date("Excelent", "Un produs de nota 10");
            driver.FindElement(By.XPath(enumsOpinie.nota)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(enumsOpinie.trimite)).Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Va rugam sa va exprimati acordul cu privire la politica de confidentialitate", opiniePO.txtEroare4.Text);
        }
    }
}
