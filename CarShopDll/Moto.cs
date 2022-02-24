using System;
using System.Collections.Generic;
using System.Text;

namespace CarShopDll
{
    public enum ETipoMoto
    {
        Enduro,
        Strada,
        Trial,
        Sidecar,
        Scooter,
        Superbike
    }

    public class Moto : Veicolo
    {
        public ETipoMoto Tipo { get; set; }
        public int Tempi { get; set; }
        public int Cilindri { get; set; }
        public bool HasAbs { get; set; }
        public bool HasCts { get; set; }
        public bool HasBauletto { get; set; }

        public Moto(string marca, string modello, int cilindrata,
            float potenza, DateTime dataImmatricolazione, int km,
            float peso, EAlimentazione alimentazione, bool isAutomatico,
            int nMarce, int classeInquinamento, int nPosti, string colore,
            string targa, List<string> optional, string descrizione, double prezzo,
            ETipoMoto tipo, int tempi, int cilindri,
            bool hasAbs, bool hasCts, bool hasBauletto)
            : base(marca, modello, cilindrata, potenza, dataImmatricolazione, km, peso, alimentazione, isAutomatico,
                  nMarce, classeInquinamento, nPosti, colore, targa, optional, descrizione, prezzo)
        {
            Tipo = tipo;
            Tempi = tempi;
            Cilindri = cilindri;
            HasAbs = hasAbs;
            HasCts = hasCts;
            HasBauletto = hasBauletto;
        }

        public Moto(string marca, string modello,
            ETipoMoto tipo, int tempi, bool hasAbs)
            : base(marca, modello)
        {
            Tipo = tipo;
            Tempi = tempi;
            HasAbs = hasAbs;
        }

        public override string ToString()
        {
            string retVal = "Moto " + Tipo +": " + base.ToString();
            string stAbs = HasAbs ? " ABS " : " ";
            retVal += stAbs + Tempi + " tempi";
            return retVal;
        }

    }
}
