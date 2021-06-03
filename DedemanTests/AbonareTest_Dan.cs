using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using DedemanTests.PO_Dan;
using OpenQA.Selenium.Interactions;
using DedemanTests.Enums_Dan;

namespace DedemanTests
{
    [TestClass]
    public class AbonareTest_Dan
    {

        private IWebDriver driver;
        private AbonareNewsletterPO abonareNewsletterPO;
        private Actions actions;
        private Enums_Abonare enumsAbonare;


        [TestInitialize]
        public void testInitialize()
        {
            driver = new ChromeDriver();
            abonareNewsletterPO = new AbonareNewsletterPO(driver);
            enumsAbonare = new Enums_Abonare();
            actions = new Actions(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.dedeman.ro/");
            Thread.Sleep(3000);
        }

        [TestMethod]
        public void abonarecorecta()
        {
            driver.FindElement(By.XPath(enumsAbonare.numePrenume)).SendKeys("Dan Segall");
            driver.FindElement(By.XPath(enumsAbonare.adresaEmail)).SendKeys("test@gmail.com");
            driver.FindElement(By.XPath(enumsAbonare.acordDate)).Click();
            driver.FindElement(By.XPath(enumsAbonare.aboneazaMa)).Click();
            Thread.Sleep(4000);
            Assert.AreEqual("Ai fost abonat cu succes.", abonareNewsletterPO.TextSuccessAbonare.Text);
        }

        [TestMethod]
        public void numeprenumegresit()
        {
            driver.FindElement(By.XPath(enumsAbonare.numePrenume)).SendKeys("Dan");
            driver.FindElement(By.XPath(enumsAbonare.adresaEmail)).SendKeys("test@test.com");
            driver.FindElement(By.XPath(enumsAbonare.acordDate)).Click();
            driver.FindElement(By.XPath(enumsAbonare.aboneazaMa)).Click();
            Thread.Sleep(4000);
            Assert.AreEqual("Te rugăm să introduci numele și prenumele complet.", abonareNewsletterPO.TextFailNume.Text);
        }

        [TestMethod]
        public void emailgol()
        {
            driver.FindElement(By.XPath(enumsAbonare.numePrenume)).SendKeys("Dan Segall");
            driver.FindElement(By.XPath(enumsAbonare.adresaEmail)).SendKeys(" ");
            driver.FindElement(By.XPath(enumsAbonare.acordDate)).Click();
            driver.FindElement(By.XPath(enumsAbonare.aboneazaMa)).Click();
            Thread.Sleep(4000);
            Assert.AreEqual("Te rugăm să introduci adresa de e-mail.", abonareNewsletterPO.TextFailEmailGol.Text);
        }
        public void emailgresit()
        {
            driver.FindElement(By.XPath(enumsAbonare.numePrenume)).SendKeys("Dan Segall");
            driver.FindElement(By.XPath(enumsAbonare.adresaEmail)).SendKeys("testprost");
            driver.FindElement(By.XPath(enumsAbonare.acordDate)).Click();
            driver.FindElement(By.XPath(enumsAbonare.aboneazaMa)).Click();
            Thread.Sleep(4000);
            Assert.AreEqual("Te rugăm să introduci o adresă de e-mail validă.", abonareNewsletterPO.TextFailEmailGresit.Text);
        }

        [TestMethod]
        public void acordgresit()
        {
            driver.FindElement(By.XPath(enumsAbonare.numePrenume)).SendKeys("Dan Segall");
            driver.FindElement(By.XPath(enumsAbonare.adresaEmail)).SendKeys("test@gmail.com");
            driver.FindElement(By.XPath(enumsAbonare.aboneazaMa)).Click();
            Thread.Sleep(4000);
            Assert.AreEqual("Te rugăm să-ți exprimi acordul cu privire la politica de confidențialitate.", abonareNewsletterPO.TextFailAcord.Text);
        }

        [TestCleanup]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
