using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedemanTests.Enums_Dan
{
    public class Enums_Job
    {
        public string Posturi { get; set; } = "//*[@id='app']/div/footer/div[1]/div/div/div/div[2]/ul/li[3]/a";
        public string Cookies { get; set; } = "/html/body/header/div[1]/div/div/div[2]/div/button";
        public string LocatieInitial { get; set; } = "body > div.section.section-padding.bg-gray > div > div > div > div.front > div.job-toolbar.p-3 > form > div > div:nth-child(3) > div > select";
        public string Locatie { get; set; } = "/html/body/div[4]/div/div/div/div[1]/div[1]/form/div/div[3]/div/select/option[10]";
        public string Cautare { get; set; } = "/html/body/div[4]/div/div/div/div[1]/div[1]/form/div/div[4]/button";
        public string TitluJob { get; set; } = "/html/body/div[4]/div/div/div/div[1]/div[1]/form/div/div[2]/input";
        public string VeziDetalii { get; set; } = "/html/body/div[4]/div/div/div/div[2]/div[2]/div/div/div/div/div/div[3]/div/a";
        public string Aplica { get; set; } = "/html/body/div[6]/div[2]/div[1]/div[1]/div/div/div/div[2]/button";
        public string Derulati { get; set; } = "//*[@id='termeni']/div/div/div[3]/button";
        public string Consimtamant { get; set; } = "//*[@id='accept-terms-yes']";
        public string Continua { get; set; } = "//*[@id='termeni']/div/div/div[3]/div[2]/div[3]/button";
        public string Nume { get; set; } = "//*[@id='apply-form']/div/div/div[1]/div/div[1]/input";
        public string Prenume { get; set; } = "//*[@id='apply-form']/div/div/div[1]/div/div[2]/input";
        public string Email { get; set; } = "//*[@id='apply-form']/div/div/div[1]/div/div[3]/input";
        public string Telefon { get; set; } = "//*[@id='apply-form']/div/div/div[1]/div/div[4]/input";
        public string Judet { get; set; } = "//*[@id='apply-form']/div/div/div[2]/div/div[1]/select/option[26]";
        public string LocalitateClick { get; set; } = "//*[@id='apply-form']/div/div/div[2]/div/div[2]/select";
        public string Localitate { get; set; } = "//*[@id='apply-form']/div/div/div[2]/div/div[2]/select/option[198]";
        public string AlegeLocalitate { get; set; } = "//*[@id='apply-form']/div/div/div[2]/div/div[2]/select/option[1]";
        public string CVlipsa { get; set; } = "//*[@id='apply-form']/div/div/div[1]/div/div[3]/p[2]";
        public string AcordRadio { get; set; } = "//*[@id='not-agree-future-selections']";
        public string AcordCheck { get; set; } = "//*[@id='aplica']/div/div/div[2]/div/div[2]/div/div[2]/label/span[1]";
        public string EmailGresit { get; set; } = "//*[@id='apply-form']/div/div/div[1]/div/div[3]/p[2]";
        public string TelefonGresit { get; set; } = "//*[@id='apply-form']/div/div/div[1]/div/div[4]/p[2]";
        public string LocalitateGresita { get; set; } = "//*[@id='apply-form']/div/div/div[2]/div/div[2]/p[2]";
    }
}
