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
    public class ContactPagePO
    {
        private IWebDriver driver;
        private EnumsContactPage EnumsContactPage = new EnumsContactPage();
        public IWebElement btnContact => driver.FindElement(By.XPath(EnumsContactPage.contact));
        public IWebElement btnTip => driver.FindElement(By.XPath(EnumsContactPage.tip));
        public IWebElement txtNume => driver.FindElement(By.XPath(EnumsContactPage.nume));
        public IWebElement txtEmail => driver.FindElement(By.XPath(EnumsContactPage.email));
        public IWebElement txtTelefon => driver.FindElement(By.XPath(EnumsContactPage.telefon));
        public IWebElement txtMesaj => driver.FindElement(By.XPath(EnumsContactPage.mesaj));
        public IWebElement btnAcord => driver.FindElement(By.XPath(EnumsContactPage.acord));
        public IWebElement btnTrimite => driver.FindElement(By.XPath(EnumsContactPage.trimite));
        public IWebElement txtReusita => driver.FindElement(By.XPath(EnumsContactPage.reusita));
        public IWebElement txtEroare => driver.FindElement(By.XPath(EnumsContactPage.eroare));
        public IWebElement txtEroare2 => driver.FindElement(By.XPath(EnumsContactPage.eroare2));
        public IWebElement txtEroare3 => driver.FindElement(By.XPath(EnumsContactPage.eroare3));
        public IWebElement txtEroare4 => driver.FindElement(By.XPath(EnumsContactPage.eroare4));
        public IWebElement btnAccept => driver.FindElement(By.XPath(EnumsContactPage.accept));
        public ContactPagePO(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void completeaza_date(string nume, string email, string mesaj)
        {
            btnAccept.Click();
            Thread.Sleep(2000);
            btnTip.Click();
            Thread.Sleep(2000);
            txtNume.SendKeys(nume);
            Thread.Sleep(2000);
            txtEmail.SendKeys(email);
            Thread.Sleep(2000);
            txtMesaj.SendKeys(mesaj);
            Thread.Sleep(2000);
            btnAcord.Click();
            Thread.Sleep(2000);

        }

        /*public void select_contact()
        {
            btnContact.Click();
            Thread.Sleep(1000);
        }*/

        /*public void select_tip()
        {
            btnTip.Click();
        }*/
    }
}
