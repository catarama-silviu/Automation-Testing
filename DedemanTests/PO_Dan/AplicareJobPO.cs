using OpenQA.Selenium;
using System.Threading;
using DedemanTests.Enums_Dan;


namespace DedemanTests.PO_Dan
{
    class AplicareJobPO
    {
        private IWebDriver driver;
        private Enums_Job enums_Job = new Enums_Job();
        public IWebElement BtnCookies => driver.FindElement(By.XPath(enums_Job.Cookies));
        public IWebElement BtnCariere => driver.FindElement(By.XPath(enums_Job.Posturi));
        public IWebElement BtnLocatie1 => driver.FindElement(By.CssSelector(enums_Job.LocatieInitial));
        public IWebElement BtnLocatie2 => driver.FindElement(By.XPath(enums_Job.Locatie));
        public IWebElement BtnCautare => driver.FindElement(By.XPath(enums_Job.Cautare));
        public IWebElement BtnTitluJob => driver.FindElement(By.XPath(enums_Job.TitluJob));
        public IWebElement BtnDetalii => driver.FindElement(By.XPath(enums_Job.VeziDetalii));
        public IWebElement BtnAplica => driver.FindElement(By.XPath(enums_Job.Aplica));
        public IWebElement BtnDerulati => driver.FindElement(By.XPath(enums_Job.Derulati));
        public IWebElement BtnConsimtamant => driver.FindElement(By.XPath(enums_Job.Consimtamant));
        public IWebElement TextNume => driver.FindElement(By.XPath(enums_Job.Nume));
        public IWebElement TextPrenume => driver.FindElement(By.XPath(enums_Job.Prenume));
        public IWebElement TextEmail => driver.FindElement(By.XPath(enums_Job.Email));
        public IWebElement TextTelefon => driver.FindElement(By.XPath(enums_Job.Telefon));
        public IWebElement DropJudet => driver.FindElement(By.XPath(enums_Job.Judet));
        public IWebElement DropLocalitate => driver.FindElement(By.XPath(enums_Job.Localitate));
        public IWebElement LocalitateInitial => driver.FindElement(By.XPath(enums_Job.LocalitateClick));
        public IWebElement RadioAcord => driver.FindElement(By.XPath(enums_Job.AcordRadio));
        public IWebElement CheckAcord => driver.FindElement(By.XPath(enums_Job.AcordCheck));
        public IWebElement TextCVlipsa => driver.FindElement(By.XPath(enums_Job.CVlipsa));
        public IWebElement TextEmailGresit => driver.FindElement(By.XPath(enums_Job.EmailGresit));
        public IWebElement TextTelefonGresit => driver.FindElement(By.XPath(enums_Job.TelefonGresit));
        public IWebElement TextLocalitateGresita => driver.FindElement(By.XPath(enums_Job.LocalitateGresita));

        public AplicareJobPO(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void aplicareJob(string Nume, string Prenume, string Email, string Telefon, string TitluJob)
        {
            BtnCookies.Click();
            Thread.Sleep(1500);
            BtnLocatie1.Click();
            Thread.Sleep(1000);
            BtnLocatie2.Click();
            Thread.Sleep(1000);
            BtnTitluJob.SendKeys(TitluJob);
            Thread.Sleep(1000);
            BtnCautare.Click();
            Thread.Sleep(1000);
            BtnDetalii.Click();
            Thread.Sleep(1000);
            BtnAplica.Click();
            Thread.Sleep(1000);
            BtnDerulati.Click();
            Thread.Sleep(1000);
            BtnConsimtamant.Click();
            Thread.Sleep(1000);
            TextNume.SendKeys(Nume);
            Thread.Sleep(1000);
            TextPrenume.SendKeys(Prenume);
            Thread.Sleep(1000);
            TextEmail.SendKeys(Email);
            Thread.Sleep(1000);
            TextTelefon.SendKeys(Telefon);
            Thread.Sleep(1000);
            DropJudet.Click();
            Thread.Sleep(1000);
            LocalitateInitial.Click();
            Thread.Sleep(1000);
            DropLocalitate.Click();
            Thread.Sleep(1000);
            RadioAcord.Click();
            Thread.Sleep(1000);
            CheckAcord.Click();
            Thread.Sleep(1000);
        }
    }
}