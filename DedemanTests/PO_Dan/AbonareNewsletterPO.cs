using OpenQA.Selenium;
using System.Threading;
using DedemanTests.Enums_Dan;


namespace DedemanTests.PO_Dan
{
    class AbonareNewsletterPO
    {
        private IWebDriver driver;
        private Enums_Abonare enums_Abonare = new Enums_Abonare();
        public IWebElement TextNumePrenume => driver.FindElement(By.XPath(enums_Abonare.numePrenume));
        public IWebElement TextEmail => driver.FindElement(By.XPath(enums_Abonare.adresaEmail));
        public IWebElement CheckboxAcord => driver.FindElement(By.XPath(enums_Abonare.acordDate));
        public IWebElement BtnAbonare => driver.FindElement(By.XPath(enums_Abonare.aboneazaMa));
        public IWebElement TextFailNume => driver.FindElement(By.XPath(enums_Abonare.failNume));
        public IWebElement TextFailEmailGol => driver.FindElement(By.XPath(enums_Abonare.failEmailGol));
        public IWebElement TextFailEmailGresit => driver.FindElement(By.XPath(enums_Abonare.failEmailGresit));
        public IWebElement TextFailAcord => driver.FindElement(By.XPath(enums_Abonare.failAcord));
        public IWebElement TextSuccessAbonare => driver.FindElement(By.XPath(enums_Abonare.successAbonare));

        public AbonareNewsletterPO(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void completareAbonare(string numePrenume, string adresaEmail)
        {
            TextNumePrenume.Click();
            Thread.Sleep(1000);
            TextNumePrenume.SendKeys(numePrenume);
            Thread.Sleep(1000);
            TextEmail.Click();
            Thread.Sleep(1000);
            TextEmail.SendKeys(adresaEmail);
            Thread.Sleep(1000);
            CheckboxAcord.Click();
            Thread.Sleep(1000);
            BtnAbonare.Click();


        }
    }
}
