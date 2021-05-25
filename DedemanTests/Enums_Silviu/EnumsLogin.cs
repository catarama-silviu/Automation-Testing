using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedemanTests.Enums
{
   public class EnumsLogin
    {

        public string contulMeu { get; set; } =  "li>i[class='icon-user']+span[class='semibold inline-block vertical-middle item-text']";
        public string autentifica_te { get; set; } = "a[class='button  blue-gradient slim']";
        public string state { get; set; } = "//input[@placeholder='Alege judetul']";
        public string city { get; set; } = "//input[@placeholder='Alege localitatea']";
        public string email { get; set; } = "div > label[class='label']+input[type = 'email']";
        public string password { get; set; } = "input[type='password']";
        public string button_autentifica_te { get; set; } = "button[class='button  blue-gradient block full-width large basic-margin-bottom relative']";
        public string txtFailLogin { get; set; } = "div[class='form-row error']>div>div[class='info-box-content']";
        public string txtSuccessfulyLogin { get; set; } = "p[class='customer-name']";


    }
}
