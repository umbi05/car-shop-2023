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

        public Moto(string marca, string modello, int cilindrata, string classeInquinamento, bool isAutomatico, DateTime annoImmatricolazione, double prezzo, string alimentazione, List<string> optional, double potenza, int nPosti, string colore, string targa, int km, int nMarce,
            string tipoCarrozzeria, int tempi, string versione, Avviamento avviamento, bool isDepotenziata, string sella, bool hasCupolino, bool hasBauletto)
            : base(marca, modello, cilindrata, classeInquinamento, isAutomatico, annoImmatricolazione, prezzo, alimentazione, optional, potenza, nPosti, colore, targa, km, nMarce)
        {
            TipoCarrozzeria = tipoCarrozzeria;
            Tempi = tempi;
            Versione = versione;
            Avviamento = avviamento;
            IsDepotenziata = isDepotenziata;
            Sella = sella;
            HasCupolino = hasCupolino;
            HasBauletto = hasBauletto;
        }

        public override string ToString()
        {
            string st = "Moto: " + Marca + " - " + Modello + " - " + Tempi + " tempi";
            return st;
        }
    }

}
