using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedemanTests.Enums_Dan
{
    public class Enums_Abonare
    {
        public string numePrenume { get; set; } = "//*[@id='app']/div/div[4]/div[7]/form/div/div[1]/div[1]/input";
        public string adresaEmail { get; set; } = "//*[@id='app']/div/div[4]/div[7]/form/div/div[1]/div[2]/input";
        public string acordDate { get; set; } = "//*[@id='policy-agree']";
        public string aboneazaMa { get; set; } = "//*[@id='app']/div/div[4]/div[7]/form/button";
        public string failNume { get; set; } = "//*[@id='app']/div/div[4]/div[7]/form/div/div[1]/div[1]/div/div";
        public string failEmailGol { get; set; } = "//*[@id='app']/div/div[4]/div[7]/form/div/div[1]/div[2]/div/div";
        public string failEmailGresit { get; set; } = "//*[@id='app']/div/div[4]/div[7]/form/div/div[1]/div[2]/div/div";
        public string failAcord { get; set; } = "//*[@id='app']/div/div[4]/div[7]/form/div/div[2]/div[2]/div";
        public string successAbonare { get; set; } = "//*[@id='app']/div/div[4]/div[7]/form/div/span";

    }
}
