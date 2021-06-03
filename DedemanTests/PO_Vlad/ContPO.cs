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
    public class ContPO
    {
        private IWebDriver driver;
        private EnumsCont EnumsCont = new EnumsCont();
        public IWebElement txtState => driver.FindElement(By.XPath(EnumsCont.state));
        public IWebElement txtCity => driver.FindElement(By.XPath(EnumsCont.city));
        public IWebElement txtEmail => driver.FindElement(By.CssSelector(EnumsCont.email));
        public IWebElement txtPassword => driver.FindElement(By.CssSelector(EnumsCont.password));
        public IWebElement btnAutentifica_te => driver.FindElement(By.CssSelector(EnumsCont.button_autentifica_te));
        public IWebElement btnSetari => driver.FindElement(By.XPath(EnumsCont.setari));
        public IWebElement btnAccept => driver.FindElement(By.XPath(EnumsCont.accept));
        public IWebElement txtNume => driver.FindElement(By.XPath(EnumsCont.nume));
        public IWebElement txtPrenume => driver.FindElement(By.XPath(EnumsCont.prenume));
        public IWebElement btnSalveaza => driver.FindElement(By.XPath(EnumsCont.salveaza));
        public IWebElement txtReusita => driver.FindElement(By.XPath(EnumsCont.reusita));
        public IWebElement txtEroare => driver.FindElement(By.XPath(EnumsCont.eroare));
        public IWebElement txtEroare2 => driver.FindElement(By.XPath(EnumsCont.eroare2));

        public ContPO(IWebDriver driver)
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

        public void schimbare_date(string nume, string prenume)
        {
            txtNume.Clear();
            txtNume.SendKeys(nume);
            Thread.Sleep(2000);
            txtPrenume.Clear();
            txtPrenume.SendKeys(prenume);
            Thread.Sleep(2000);
        }
    }
}
