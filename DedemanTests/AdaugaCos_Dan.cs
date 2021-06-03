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
    public class AdaugaCos_Dan
    {

        private IWebDriver driver;
        private AdaugaCosPO adaugaCos;
        private Actions actions;
        private Enums_CosCumparaturi enums_CosCumparaturi;


        [TestInitialize]
        public void testInitialize()
        {
            driver = new ChromeDriver();
            adaugaCos = new AdaugaCosPO(driver);
            enums_CosCumparaturi = new Enums_CosCumparaturi();
            actions = new Actions(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.dedeman.ro/alba-iulia/gradina/c/17");
            Thread.Sleep(3000);
        }

        [TestMethod]
        public void adaugareCosCumparaturi()
        {
            driver.FindElement(By.XPath(enums_CosCumparaturi.Cookies)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(enums_CosCumparaturi.Instalatii)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(enums_CosCumparaturi.Conectori)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(enums_CosCumparaturi.Descendent)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(enums_CosCumparaturi.Distribuitor)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(enums_CosCumparaturi.RandomClick)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(enums_CosCumparaturi.BucatiUp)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_CosCumparaturi.BucatiUp)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_CosCumparaturi.AdaugaCos)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_CosCumparaturi.Judet)).SendKeys("Iasi");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(enums_CosCumparaturi.RandomClick2)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_CosCumparaturi.Localitate)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_CosCumparaturi.Localitate)).SendKeys("Iasi");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_CosCumparaturi.RandomClick2)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(enums_CosCumparaturi.AlegeMagazin)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(enums_CosCumparaturi.ContinuaCumparaturi)).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath(enums_CosCumparaturi.Finalizare)).Click();
            Thread.Sleep(3000);
            Assert.AreEqual("Produse livrabile din magazinul online sau din magazinul tau", adaugaCos.TextSuccesFinalizare.Text);
        }
        
        [TestCleanup]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
