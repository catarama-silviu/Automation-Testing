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
    public class ContactTest_Vlad
    {
        private IWebDriver driver;
        private ContactPagePO contactPagePO;
        private Actions actions;
        private EnumsContactPage enumsContactPage;

        [TestInitialize]
        public void testInitialize()
        {
            driver = new ChromeDriver();
            contactPagePO = new ContactPagePO(driver);
            enumsContactPage = new EnumsContactPage();
            actions = new Actions(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.dedeman.ro/");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(enumsContactPage.contact)).Click();
        }

        [TestCleanup]
        public void cleanup()
        {
            driver.Quit();
        }

        [TestMethod]
        public void contact_corect()
        {
            Thread.Sleep(3000);
            contactPagePO.completeaza_date("Ciubotaru Andrei", "ciuboss@gmail.com", "Serviciile dumneavoastra m-au dezamagit");
            enumsContactPage = new EnumsContactPage();
            driver.FindElement(By.XPath(enumsContactPage.trimite)).Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Informatiile au fost trimise catre Serviciul Suport Clienti Dedeman.", contactPagePO.txtReusita.Text);
        }

        [TestMethod]
        public void contact_gresitNume()
        {
            Thread.Sleep(3000);
            contactPagePO.completeaza_date("", "ciuboss@gmail.com", "Serviciile dumneavoastra m-au dezamagit");
            enumsContactPage = new EnumsContactPage();
            driver.FindElement(By.XPath(enumsContactPage.trimite)).Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Acesta este un camp obligatoriu", contactPagePO.txtEroare.Text);
        }

        [TestMethod]
        public void contact_gresitEmail()
        {
            Thread.Sleep(3000);
            contactPagePO.completeaza_date("Ciubotaru Andrei", "", "Serviciile dumneavoastra m-au dezamagit");
            enumsContactPage = new EnumsContactPage();
            driver.FindElement(By.XPath(enumsContactPage.trimite)).Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Acesta este un camp obligatoriu", contactPagePO.txtEroare2.Text);
        }

        [TestMethod]
        public void contact_gresitMesaj()
        {
            Thread.Sleep(3000);
            contactPagePO.completeaza_date("Ciubotaru Andrei", "ciuboss@gmail.com", "");
            enumsContactPage = new EnumsContactPage();
            driver.FindElement(By.XPath(enumsContactPage.trimite)).Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Acesta este un camp obligatoriu", contactPagePO.txtEroare3.Text);
        }

        [TestMethod]
        public void contact_gresitAcord()
        {
            Thread.Sleep(3000);
            contactPagePO.completeaza_date("Ciubotaru Andrei", "ciuboss@gmail.com", "Serviciile dumneavoastra m-au dezamagit");
            enumsContactPage = new EnumsContactPage();
            driver.FindElement(By.XPath(enumsContactPage.acord)).Click();
            driver.FindElement(By.XPath(enumsContactPage.trimite)).Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Va rugam sa va exprimati acordul cu privire la politica de confidentialitate", contactPagePO.txtEroare4.Text);
        }
    }
}
