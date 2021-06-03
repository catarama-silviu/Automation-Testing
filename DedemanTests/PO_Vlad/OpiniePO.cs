using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using DedemanTests.Enums_Vlad;

namespace DedemanTests.PO_Vlad
{
    public class OpiniePO
    {
        private IWebDriver driver;
        private EnumsOpinie EnumsOpinie = new EnumsOpinie();
        public IWebElement txtState => driver.FindElement(By.XPath(EnumsOpinie.state));
        public IWebElement txtCity => driver.FindElement(By.XPath(EnumsOpinie.city));
        public IWebElement txtEmail => driver.FindElement(By.CssSelector(EnumsOpinie.email));
        public IWebElement txtPassword => driver.FindElement(By.CssSelector(EnumsOpinie.password));
        public IWebElement btnAutentifica_te => driver.FindElement(By.CssSelector(EnumsOpinie.button_autentifica_te));
        public IWebElement txtSearchInput => driver.FindElement(By.CssSelector(EnumsOpinie.search_input));
        public IWebElement btnSearch => driver.FindElement(By.CssSelector(EnumsOpinie.search_button));
        public IWebElement txtLawnMower => driver.FindElement(By.CssSelector(EnumsOpinie.txtLawnMower));
        public IWebElement btnPoza => driver.FindElement(By.XPath(EnumsOpinie.poza));
        public IWebElement btnOpinie => driver.FindElement(By.XPath(EnumsOpinie.opinie));
        public IWebElement txtTitlu => driver.FindElement(By.XPath(EnumsOpinie.titlu));
        public IWebElement btnNota => driver.FindElement(By.XPath(EnumsOpinie.nota));
        public IWebElement txtMesaj => driver.FindElement(By.XPath(EnumsOpinie.mesaj));
        public IWebElement btnAcord => driver.FindElement(By.XPath(EnumsOpinie.acord));
        public IWebElement btnTrimite => driver.FindElement(By.XPath(EnumsOpinie.trimite));
        public IWebElement btnAccept => driver.FindElement(By.XPath(EnumsOpinie.accept));
        public IWebElement txtReusita => driver.FindElement(By.XPath(EnumsOpinie.reusita));
        public IWebElement txtEroare => driver.FindElement(By.XPath(EnumsOpinie.eroare));
        public IWebElement txtEroare2 => driver.FindElement(By.XPath(EnumsOpinie.eroare2));
        public IWebElement txtEroare3 => driver.FindElement(By.XPath(EnumsOpinie.eroare3));
        public IWebElement txtEroare4 => driver.FindElement(By.XPath(EnumsOpinie.eroare4));

        public OpiniePO(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void select_State_City(string state, string city)
        {
            txtState.Click();
            Thread.Sleep(1000);
            txtState.SendKeys(state);
            Thread.Sleep(1000);
            txtCity.Click();
            Thread.Sleep(1000);
            txtCity.SendKeys(city);
            Thread.Sleep(1000);
            txtCity.SendKeys(Keys.Tab);
        }

        public void login(string email, string password)
        {
            txtEmail.SendKeys(email);
            txtPassword.SendKeys(password);
            btnAutentifica_te.Click();
        }

        public void searchProducts(String product)
        {
            txtSearchInput.SendKeys(product);
            Thread.Sleep(1000);
            btnSearch.Click();
            Thread.Sleep(2000);
            btnPoza.Click();
            Thread.Sleep(2000);
            btnAccept.Click();
        }

        public void completeaza_date(string titlu, string mesaj)
        {
            txtTitlu.SendKeys(titlu);
            Thread.Sleep(2000);
            txtMesaj.SendKeys(mesaj);
            Thread.Sleep(2000);
        }
    }
}
