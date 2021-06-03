using OpenQA.Selenium;
using System.Threading;
using DedemanTests.Enums_Dan;


namespace DedemanTests.PO_Dan
{
    class AdaugaCosPO
    {
        private IWebDriver driver;
        private Enums_CosCumparaturi enums_CosCumparaturi = new Enums_CosCumparaturi();
        public IWebElement BtnCookies => driver.FindElement(By.XPath(enums_CosCumparaturi.Cookies));
        public IWebElement BtnInstalatii => driver.FindElement(By.XPath(enums_CosCumparaturi.Instalatii));
        public IWebElement BtnConectori => driver.FindElement(By.XPath(enums_CosCumparaturi.Conectori));
        public IWebElement BtnDescendent => driver.FindElement(By.XPath(enums_CosCumparaturi.Descendent));
        public IWebElement BtnDistribuitor => driver.FindElement(By.XPath(enums_CosCumparaturi.Distribuitor));
        public IWebElement BtnBucatiUp => driver.FindElement(By.XPath(enums_CosCumparaturi.BucatiUp));
        public IWebElement BtnAdaugaCos => driver.FindElement(By.XPath(enums_CosCumparaturi.AdaugaCos));
        public IWebElement BtnFinalizare => driver.FindElement(By.XPath(enums_CosCumparaturi.Finalizare));
        public IWebElement TextSuccesAdaugare => driver.FindElement(By.XPath(enums_CosCumparaturi.succesAdaugare));
        public IWebElement TextSuccesFinalizare => driver.FindElement(By.XPath(enums_CosCumparaturi.succesFinalizare));
        public IWebElement TextJudet => driver.FindElement(By.XPath(enums_CosCumparaturi.Judet));
        public IWebElement TextLocalitate => driver.FindElement(By.XPath(enums_CosCumparaturi.Localitate));
        public IWebElement ClickRandomClick => driver.FindElement(By.XPath(enums_CosCumparaturi.RandomClick));
        public IWebElement BtnMagazin => driver.FindElement(By.XPath(enums_CosCumparaturi.AlegeMagazin));
        public IWebElement BtnContinua => driver.FindElement(By.XPath(enums_CosCumparaturi.ContinuaCumparaturi));
        public IWebElement ClickRandomClick2 => driver.FindElement(By.XPath(enums_CosCumparaturi.RandomClick2));

        public AdaugaCosPO(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void adaugareCumparaturi(string Judet, string Localitate)
        {
            BtnCookies.Click();
            Thread.Sleep(2000);
            BtnInstalatii.Click();
            Thread.Sleep(2000);
            BtnConectori.Click();
            Thread.Sleep(2000);
            BtnDescendent.Click();
            Thread.Sleep(2000);
            BtnDistribuitor.Click();
            Thread.Sleep(2000);
            ClickRandomClick.Click();
            Thread.Sleep(2000);
            BtnBucatiUp.Click();
            Thread.Sleep(1000);
            BtnBucatiUp.Click();
            Thread.Sleep(1000);
            BtnAdaugaCos.Click();
            Thread.Sleep(2000);
            TextJudet.SendKeys(Judet);
            Thread.Sleep(2000);
            TextLocalitate.Click();
            Thread.Sleep(2000);
            TextLocalitate.SendKeys(Localitate);
            Thread.Sleep(2000);
            ClickRandomClick2.Click();
            Thread.Sleep(2000);
            BtnMagazin.Click();
            Thread.Sleep(2000);
            BtnContinua.Click();
            Thread.Sleep(4000);
            BtnFinalizare.Click();
        }
    }
}
