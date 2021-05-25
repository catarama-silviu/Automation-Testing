using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using DedemanTests.PO;
using OpenQA.Selenium.Interactions;
using DedemanTests.Enums;
using DedemanTests.Enums_Silviu;
using DedemanTests.PO_Silviu;

namespace DedemanTests
{
    [TestClass]
    public class SearchForAProduct_Silviu

    {
        private IWebDriver driver;
        private LoginPagePO loginPagePO;
        private Actions actions;
        private EnumsLogin enumsLogin;
        private SearchForAProductPO searchForAProductPO;
        [TestInitialize]
        public void testInitialize()
        {
            driver = new ChromeDriver();
            loginPagePO = new LoginPagePO(driver);
            enumsLogin = new EnumsLogin();
            actions = new Actions(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.dedeman.ro/");
            Thread.Sleep(2000);
            actions.MoveToElement(driver.FindElement(By.CssSelector(enumsLogin.contulMeu))).Perform();
            driver.FindElement(By.CssSelector(enumsLogin.autentifica_te)).Click();
            loginPagePO.select_State_City("Vaslui", "Poienesti");
            Thread.Sleep(4000);
            loginPagePO.login("exosilviu@gmail.com", "test12345");
        }


        [TestCleanup]
        public void cleanup()
        {
           driver.Quit();
        }


        [TestMethod]
        public void searchProduct()
        {

            //search the most expensive product from EGO brand
            Thread.Sleep(3000);
            searchForAProductPO = new SearchForAProductPO(driver);
            searchForAProductPO.searchProducts("masini de tuns iarba EGO");
            Thread.Sleep(5000);
            searchForAProductPO.SelectItemOrdoneaza("Pret (lei) descendent");
            Assert.AreEqual("Masina de tuns gazon Ego LM1903E-SP, cu acumulator li-ion 56 V / 5 Ah si incarcator rapid, 47 cm",searchForAProductPO.txtLawnMower.Text);
        }


    }
}
