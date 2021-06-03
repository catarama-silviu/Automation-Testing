using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedemanTests.Enums_Vlad
{
    public class EnumsContactPage
    {
        public string contact { get; set; } = "//*[@id='app']/div/div[2]/div[1]/div/div[2]/div[1]/div[2]/div/div/ul/li[7]/a";
        public string tip { get; set; } = "//*[@id='app']/main/div[2]/div/div[2]/div/form/div[1]/div[1]/div/div[2]/div[1]";
        public string nume { get; set; } = "//*[@id='app']/main/div[2]/div/div[2]/div/form/div[2]/div/div/div[2]/div[1]/input";
        public string email { get; set; } = "//*[@id='app']/main/div[2]/div/div[2]/div/form/div[2]/div/div/div[2]/div[2]/input";
        public string telefon { get; set; } = "//*[@id='app']/main/div[2]/div/div[2]/div/form/div[2]/div/div/div[2]/div[3]/input";
        public string mesaj { get; set; } = "//*[@id='app']/main/div[2]/div/div[2]/div/form/div[2]/div/div/div[2]/div[4]/div/textarea";
        public string acord { get; set; } = "//*[@id='app']/main/div[2]/div/div[2]/div/form/div[3]/div[1]/div[1]/span";
        public string trimite { get; set; } = "//*[@id='app']/main/div[2]/div/div[2]/div/form/div[3]/div[2]/button";
        public string reusita { get; set; } = "//*[@id='app']/main/div[2]/div/div[2]/div/div[2]/div/span";
        public string eroare { get; set; } = "//*[@id='app']/main/div[2]/div/div[2]/div/form/div[2]/div/div/div[2]/div[1]/div/div";
        public string eroare2 { get; set; } = "//*[@id='app']/main/div[2]/div/div[2]/div/form/div[2]/div/div/div[2]/div[2]/div/div";
        public string eroare3 { get; set; } = "//*[@id='app']/main/div[2]/div/div[2]/div/form/div[2]/div/div/div[2]/div[4]/div/div/div";
        public string eroare4 { get; set; } = "//*[@id='app']/main/div[2]/div/div[2]/div/form/div[3]/div[1]/div[2]/div";
        public string accept { get; set; } = "//*[@id='app']/footer/div[1]/div/div/div[2]/div/a[1]";
    }
}
