using System;
using System.Collections.Generic;
using System.Text;

namespace CarShopDLL
{
    public enum Avviamento { Manuale, Automatico }
    public class Moto : Veicolo
    {
        public string TipoCarrozzeria { get; set; }
        public int Tempi { get; set; }
        public string Versione { get; set; }
        public Avviamento Avviamento { get; set; }
        public bool IsDepotenziata { get; set; }
        public string Sella { get; set; }
        public bool HasCupolino { get; set; }
        public bool HasBauletto { get; set; }

        public Moto(string marca, string modello, int cilindrata, int nPosti, string colore, string targa, int tempi, string tipoCarrozzeria)
        {
            Marca = marca;
            Modello = modello;
            Cilindrata = cilindrata;
            NPosti = nPosti;
            Colore = colore;
            Targa = targa;
            Tempi = tempi;
            TipoCarrozzeria = tipoCarrozzeria;
        }

        public override string ToString()
        {
            string st = "Moto: " + Marca + " - " + Modello + " - " + Tempi + " tempi";
            return st;
        }
    }

}
