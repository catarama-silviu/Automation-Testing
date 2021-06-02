using DedemanTests.Enums;
using DedemanTests.Enums_Silviu;
using DedemanTests.PO;
using DedemanTests.PO_Silviu;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace DedemanTests
{
    [TestClass]
    public class AddToFavorite_Silviu
    {
        private IWebDriver driver;
        private LoginPagePO loginPagePO;
        private Actions actions;
        private EnumsLogin enumsLogin;
        private AddToFavoritePO addToFavoritePO;
        

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
        public void ShouldAddProductToFavorite()
        {

            Thread.Sleep(3000);
            addToFavoritePO = new AddToFavoritePO(driver);
            addToFavoritePO.AddProductToFavorite("Masina de tuns iarba, electrica Grunman LM-PT103 1000 W");
            Thread.Sleep(3000);
            Assert.AreEqual("Produsul a fost adaugat in lista de favorite.", addToFavoritePO.txt_addToFav.Text);
        }
    }
}
