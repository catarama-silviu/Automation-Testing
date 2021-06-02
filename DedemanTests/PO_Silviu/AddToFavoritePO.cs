using DedemanTests.Enums_Silviu;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DedemanTests.PO_Silviu
{
    public class AddToFavoritePO
    {

        private IWebDriver driver;
        private Actions actions;
        private SearchForAProductPO searchForAProductPO;
        private Enums_AddproductToFavorite enums_AddproductToFavorite = new Enums_AddproductToFavorite();
        public IWebElement txt_button_product => driver.FindElement(By.CssSelector(enums_AddproductToFavorite.txt_button_product));
        public IWebElement btn_AddProoductToFavorite => driver.FindElement(By.CssSelector(enums_AddproductToFavorite.button_addproductToFavorite));
        public IWebElement txt_addToFav => driver.FindElement(By.CssSelector(enums_AddproductToFavorite.txt_addToFavorite));

        public IWebElement btn_accept => driver.FindElement(By.CssSelector("a[class='button orange-gradient inline-block vertical-middle']"));

        public AddToFavoritePO(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void AddProductToFavorite(String product) {
            searchForAProductPO = new SearchForAProductPO(driver);
            searchForAProductPO.searchProducts(product);
            Thread.Sleep(5000);
            txt_button_product.Click();
            Thread.Sleep(6000);
            btn_accept.Click();
            Thread.Sleep(1000);
            btn_AddProoductToFavorite.Click();
        }
    }
}
