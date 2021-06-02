using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using DedemanTests.Enums;
using System.Threading;
using DedemanTests.Enums_Silviu;
using OpenQA.Selenium.Support.UI;

namespace DedemanTests.PO_Silviu
{
   public class SearchForAProductPO
    {
        private IWebDriver driver;
        private Enums_Search_For_A_Product enumsSearch = new Enums_Search_For_A_Product();
        public IWebElement txtSearchInput => driver.FindElement(By.CssSelector(enumsSearch.search_input));
        public IWebElement btnSearch => driver.FindElement(By.CssSelector(enumsSearch.search_button));
        public IWebElement lstOrdoneaza => driver.FindElement(By.CssSelector(enumsSearch.select_option));
        public IWebElement txtLawnMower => driver.FindElement(By.CssSelector(enumsSearch.txtLawnMower));

        public SearchForAProductPO(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void searchProducts(String product) {
            txtSearchInput.SendKeys(product);
            btnSearch.Click();

        }

        public void SelectItemOrdoneaza(String option)
        {

            var selectItemOrdoneaza = new SelectElement(lstOrdoneaza);
            selectItemOrdoneaza.SelectByText(option);
        }
    }
}
