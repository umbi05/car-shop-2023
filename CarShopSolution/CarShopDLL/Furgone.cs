using System;
using System.Collections.Generic;
using System.Text;

namespace CarShopDLL
{
    public class Furgone : Veicolo
    {
        public int Peso { get; set; }
        public int CapacitaCarico { get; set; }
        public string TipoCarrozzeria { get; set; }

        public Furgone(string marca, string modello, int cilindrata, int nPosti, string colore, string targa, int peso, int capacitaCarico)
        {
            Marca = marca;
            Modello = modello;
            Cilindrata = cilindrata;
            NPosti = nPosti;
            Colore = colore;
            Targa = targa;
            Peso = peso;
            CapacitaCarico = capacitaCarico;
        }

        public override string ToString()
        {
            //return base.ToString();
            string st = "Furgone: " + Marca + " - " + Modello + " (" + CapacitaCarico + " litri)";
            return st;
        }
    }

}
