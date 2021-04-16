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

        public Furgone(string marca, string modello, int cilindrata, string classeInquinamento, bool isAutomatico, DateTime annoImmatricolazione, double prezzo, string alimentazione, List<string> optional, double potenza, int nPosti, string colore, string targa, int km, DimensioniStruct dimensioni, int nMarce,
            int peso, int capacitaCarico, string tipoCarrozzeria) 
            : base(marca, modello, cilindrata, classeInquinamento, isAutomatico, annoImmatricolazione, prezzo, alimentazione, optional, potenza, nPosti, colore, targa, km, dimensioni, nMarce)
        {
            Peso = peso;
            CapacitaCarico = capacitaCarico;
            TipoCarrozzeria = tipoCarrozzeria;
        }

        public override string ToString()
        {
            //return base.ToString();
            string st = "Furgone: " + base.ToString() + " (" + CapacitaCarico + " litri)";
            return st;
        }
    }

}
