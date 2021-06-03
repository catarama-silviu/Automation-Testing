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
    public class ContTest_Vlad
    {
        private IWebDriver driver;
        private ContPO contPO;
        private Actions actions;
        private EnumsCont enumsCont;

        [TestInitialize]
        public void testInitialize()
        {
            driver = new ChromeDriver();
            contPO = new ContPO(driver);
            enumsCont = new EnumsCont();
            actions = new Actions(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.dedeman.ro/");
            Thread.Sleep(2000);
            actions.MoveToElement(driver.FindElement(By.CssSelector(enumsCont.contulMeu))).Perform();
            driver.FindElement(By.CssSelector(enumsCont.autentifica_te)).Click();
            contPO.select_State_City("Vaslui", "Poienesti");

            Thread.Sleep(3000);
            contPO.login("exosilviu@gmail.com", "test12345");
            Thread.Sleep(3000);
            actions = new Actions(driver);
            enumsCont = new EnumsCont();
            actions.MoveToElement(driver.FindElement(By.CssSelector(enumsCont.contulMeu))).Perform();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(enumsCont.setari)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(enumsCont.accept)).Click();
            Thread.Sleep(2000);
        }

        [TestCleanup]
        public void cleanup()
        {
            driver.Quit();
        }

        [TestMethod]
        public void cont_corect()
        {
            contPO.schimbare_date("Silviu", "Silviu");
            driver.FindElement(By.XPath(enumsCont.salveaza)).Click();
            Thread.Sleep(7000);
            Assert.AreEqual("Informatiile au fost modificate cu succes.", contPO.txtReusita.Text);
        }

        [TestMethod]
        public void cont_gresitNume()
        {
            contPO.schimbare_date(" ", "Andrei");
            driver.FindElement(By.XPath(enumsCont.salveaza)).Click();
            Thread.Sleep(3000);
            Assert.AreEqual("Acest camp este obligatoriu.", contPO.txtEroare.Text);
        }

        [TestMethod]
        public void cont_gresitNume2()
        {
            contPO.schimbare_date("Ciubotaru$$666", "Andrei");
            driver.FindElement(By.XPath(enumsCont.salveaza)).Click();
            Thread.Sleep(3000);
            Assert.AreEqual("Nu sunt acceptate caractere speciale.", contPO.txtEroare.Text);
        }

        [TestMethod]
        public void cont_gresitPrenume()
        {
            contPO.schimbare_date("Ciubotaru", " ");
            driver.FindElement(By.XPath(enumsCont.salveaza)).Click();
            Thread.Sleep(3000);
            Assert.AreEqual("Acest camp este obligatoriu.", contPO.txtEroare2.Text);
        }

        [TestMethod]
        public void cont_gresitPrenume2()
        {
            contPO.schimbare_date("Ciubotaru", "@ndre1");
            driver.FindElement(By.XPath(enumsCont.salveaza)).Click();
            Thread.Sleep(3000);
            Assert.AreEqual("Nu sunt acceptate caractere speciale.", contPO.txtEroare2.Text);
        }
    }
}
