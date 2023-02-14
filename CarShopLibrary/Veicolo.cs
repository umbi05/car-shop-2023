using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopLibrary
{
    public enum EAlimentazione
    {
        Undefined,
        Benzina,
        Diesel,
        Elettrica,
        GPL,
        Metano,
        FullHybrid,
        PluginHybrid
    }

    public abstract class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public string VIN { get; set; }
        public string Colore { get; set; }
        public int Km { get; set; }
        public EAlimentazione Alimentazione { get; set; }
        public int MaxSpeed { get; set; }
        public int Potenza { get; set; }
        public DateTime DataImmatricolazione { get; set; }
        public int Prezzo { get; set; }


        public Veicolo(string marca, string modello, EAlimentazione alimentazione, string colore)
        {
            Marca = marca;
            Modello = modello;
            Alimentazione = alimentazione;
            Colore = colore;
        }

        public Veicolo(string marca, string modello, string vin, string colore, int km, EAlimentazione alimentazione, int maxSpeed, int potenza, DateTime dataImmatricolazione, int prezzo) 
            : this(marca, modello, alimentazione, colore)
        {
            VIN = vin;
            Km = km;
            MaxSpeed = maxSpeed;
            Potenza = potenza;
            DataImmatricolazione = dataImmatricolazione;
            Prezzo = prezzo;
        }

        public override string ToString()
        {
            return $"{Marca} {Modello} {Alimentazione} {Colore}";
        }

        public string ToString(bool isExtended)
        {
            string stOut = ToString();
            if (isExtended)
                stOut += $" (Km {Km} - Prezzo {Prezzo} Euro)";
            return stOut;
        }

    }
}
