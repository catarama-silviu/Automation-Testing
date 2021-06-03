using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedemanTests.Enums_Vlad
{
    public class EnumsCont
    {
        public string contulMeu { get; set; } = "li>i[class='icon-user']+span[class='semibold inline-block vertical-middle item-text']";
        public string autentifica_te { get; set; } = "a[class='button  blue-gradient slim']";
        public string state { get; set; } = "//input[@placeholder='Alege judetul']";
        public string city { get; set; } = "//input[@placeholder='Alege localitatea']";
        public string email { get; set; } = "div > label[class='label']+input[type = 'email']";
        public string password { get; set; } = "input[type='password']";
        public string button_autentifica_te { get; set; } = "button[class='button  blue-gradient block full-width large basic-margin-bottom relative']";
        public string setari { get; set; } = "//*[@id='app']/div/div[2]/div[1]/div/div[2]/div[2]/div[2]/ul/li[2]/div/div[2]/ul/li[6]/a";
        public string accept { get; set; } = "//*[@id='app']/div/footer/div[1]/div/div/div[2]/div/a[1]";
        public string nume { get; set; } = "//*[@id='app']/div/div[4]/div[1]/div[2]/form/div[2]/input";
        public string prenume { get; set; } = "//*[@id='app']/div/div[4]/div[1]/div[2]/form/div[3]/input";
        public string salveaza { get; set; } = "//*[@id='app']/div/div[4]/div[1]/div[2]/form/button";
        public string reusita { get; set; } = "//*[@id='app']/div/div[4]/div[1]/span";
        public string eroare { get; set; } = "//*[@id='app']/div/div[4]/div[1]/div[2]/form/div[2]/div/div";
        public string eroare2 { get; set; } = "//*[@id='app']/div/div[4]/div[1]/div[2]/form/div[3]/div/div";
    }
}
