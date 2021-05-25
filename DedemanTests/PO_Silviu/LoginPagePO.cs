using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using DedemanTests.Enums;
using System.Threading;
using DedemanTests.Enums_Silviu;

namespace DedemanTests.PO
{
    public class LoginPagePO
    {

        private IWebDriver driver;
        private EnumsLogin enumsLogin = new EnumsLogin();
        public IWebElement txtState => driver.FindElement(By.XPath(enumsLogin.state));
        public IWebElement txtCity => driver.FindElement(By.XPath(enumsLogin.city));
        public IWebElement txtEmail => driver.FindElement(By.CssSelector(enumsLogin.email));
        public IWebElement txtPassword => driver.FindElement(By.CssSelector(enumsLogin.password));
        public IWebElement btnAutentifica_te => driver.FindElement(By.CssSelector(enumsLogin.button_autentifica_te));
        public IWebElement txtFailLogin => driver.FindElement(By.CssSelector(enumsLogin.txtFailLogin));
        public IWebElement txtSuccessifullyLogin => driver.FindElement(By.CssSelector(enumsLogin.txtSuccessfulyLogin));
        public LoginPagePO(IWebDriver driver)
        {
            this.driver = driver;
           
        }


        public void select_State_City(string state, string city) {
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

        public void login(string email, string password) {

            txtEmail.SendKeys(email);
            txtPassword.SendKeys(password);
            btnAutentifica_te.Click();
        
        }

    }
}
