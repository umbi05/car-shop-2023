using System;
using System.Collections.Generic;
using System.Text;

namespace CarShopDLL
{
    public class Auto : Veicolo
    {
        public bool IsCabrio { get; set; }
        public bool IsPanoramica { get; set; }
        public bool IsSuperBollo { get; }
        public int DiametroCerchi { get; set; }
        public int NPorte { get; set; }
        public string Trazione { get; set; }
        public string Allestimento { get; set; }
        public bool HasFendinebbia { get; set; }

        public Auto(string marca, string modello, int cilindrata, int nPosti, string colore, string targa, bool isCabrio)
        {
            Marca = marca;
            Modello = modello;
            IsCabrio = isCabrio;
            Cilindrata = cilindrata;
            NPosti = nPosti;
            Colore = colore;
            Targa = targa;
        }

        public override string ToString()
        {
            //return base.ToString();
            string st = "Auto: " + Marca + " - " + Modello;
            if (IsCabrio)
            {
                st += " (cabrio) ";
            }
            st += NPosti + " posti " + " - Colore: " + Colore;
            return st;
        }
    }
}
