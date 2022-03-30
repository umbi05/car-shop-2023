using System;
using System.Collections.Generic;

namespace CarShopDll
{
    public enum EAlimentazione
    {
        Benzina,
        Diesel,
        Elettrica,
        Ibrida,
        GPL,
        Metano,
        NonDichiarata
    }

    public abstract class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Cilindrata { get; set; }
        public float Potenza { get; set; }
        public DateTime DataImmatricolazione { get; set; }
        public int Km { get; set; }
        public float Peso { get; set; }
        public struct Dimensioni
        {
            public int Larghezza { get; set; }
            public int Lunghezza { get; set; }
            public int Altezza { get; set; }
        }
        public EAlimentazione Alimentazione { get; set; }
        public bool IsAutomatico { get; set; }
        public int NMarce { get; set; }

        /// <summary>
        /// Si intende il numero dopo la stringa "EURO "
        /// </summary>
        public int ClasseInquinamento { get; set; }

        public int NPosti { get; set; }
        public string Colore { get; set; }
        public string Targa { get; set; }
        public List<string> Optional { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }

        protected Veicolo() { }

        protected Veicolo(string marca, string modello)
        {
            Marca = marca;
            Modello = modello;
        }

        public Veicolo(string marca, string modello, int cilindrata,
            float potenza, DateTime dataImmatricolazione, int km,
            float peso, EAlimentazione alimentazione, bool isAutomatico,
            int nMarce, int classeInquinamento, int nPosti, string colore,
            string targa, List<string> optional, string descrizione,
            double prezzo) : this(marca, modello)
        {
            Cilindrata = cilindrata;
            Potenza = potenza;
            DataImmatricolazione = dataImmatricolazione;
            Km = km;
            Peso = peso;
            Alimentazione = alimentazione;
            IsAutomatico = isAutomatico;
            NMarce = nMarce;
            ClasseInquinamento = classeInquinamento;
            NPosti = nPosti;
            Colore = colore;
            Targa = targa;
            Optional = optional;
            Descrizione = descrizione;
            Prezzo = prezzo;
        }

        public override string ToString()
        {
            string retVal = Marca + " " + Modello;
            if (DataImmatricolazione.Year > 1)
            {
                retVal += " (" + DataImmatricolazione.Month + "/" + DataImmatricolazione.Year + ")";
            }
            if (Colore != null)
            {
                retVal += " - " + Colore;
            }
            return retVal;
        }
    }

}
