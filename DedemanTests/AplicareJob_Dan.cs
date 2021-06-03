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
    public class AplicareJobDan
    {

        private IWebDriver driver;
        private AplicareJobPO aplicareJobPO;
        private Actions actions;
        private Enums_Job enums_Job;


        [TestInitialize]
        public void testInitialize()
        {
            driver = new ChromeDriver();
            aplicareJobPO = new AplicareJobPO(driver);
            enums_Job = new Enums_Job();
            actions = new Actions(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://recrutare.dedeman.ro/posturi-disponibile.php");
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(enums_Job.Cookies)).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.CssSelector(enums_Job.LocatieInitial)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.Locatie)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.TitluJob)).SendKeys("Vanzari");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.Cautare)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.VeziDetalii)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.Aplica)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.Derulati)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.Consimtamant)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.Continua)).Click();
            Thread.Sleep(1000);
        }

        [TestMethod]
        public void aplicaCorect()
        {
            driver.FindElement(By.XPath(enums_Job.Nume)).SendKeys("!@&*%#&$");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.Prenume)).SendKeys("5812878124");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.Email)).SendKeys("test@whatever.com");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.Telefon)).SendKeys("0747764321");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.Judet)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.LocalitateClick)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.Localitate)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.AcordRadio)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.AcordCheck)).Click();
            Thread.Sleep(1000);
            Assert.AreNotEqual("Te rugăm să introduci o adresă de e-mail validă.", aplicareJobPO.TextEmailGresit.Text);
        }

        [TestMethod]
        public void emailGresit()
        {
            driver.FindElement(By.XPath(enums_Job.Email)).SendKeys("test");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.Telefon)).Click();
            Thread.Sleep(1000);
            Assert.AreEqual("Te rugăm să introduci o adresă de e-mail validă.", aplicareJobPO.TextEmailGresit.Text);
        }

        [TestMethod]
        public void telefonGresit()
        {
            driver.FindElement(By.XPath(enums_Job.Telefon)).SendKeys("189251892521");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.Email)).Click();
            Thread.Sleep(1000);
            Assert.AreEqual("Te rugăm să introduci un număr de telefon valid.", aplicareJobPO.TextTelefonGresit.Text);
        }

        [TestMethod]
        public void localitateGresita()
        {
            driver.FindElement(By.XPath(enums_Job.Judet)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.LocalitateClick)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(enums_Job.AlegeLocalitate)).Click();
            Thread.Sleep(1000);
            Assert.AreEqual("Te rugăm să introduci localitatea ta.", aplicareJobPO.TextLocalitateGresita.Text);
        }

        [TestCleanup]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}