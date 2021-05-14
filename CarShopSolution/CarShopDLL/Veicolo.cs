using System;
using System.Collections.Generic;

namespace CarShopDLL
{
    public abstract class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Cilindrata { get; set; }
        public string ClasseInquinamento { get; set; }
        public bool IsAutomatico { get; set; }
        public DateTime AnnoImmatricolazione { get; set; }
        public double Prezzo { get; set; }
        public string Alimentazione { get; set; }
        public List<string> Optional { get; set; }
        public double Potenza { get; set; }
        public int NPosti { get; set; }
        public string Colore { get; set; }
        public string Targa { get; set; }
        public int Km { get; set; }
        public struct DimensioniStruct
        {
            public int Lunghezza { get; set; }
            public int Larghezza { get; set; }
            public int Altezza { get; set; }

            public DimensioniStruct(int lunghezza, int larghezza, int altezza)
            {
                Lunghezza = lunghezza;
                Larghezza = larghezza;
                Altezza = altezza;
            }
        }
        public DimensioniStruct Dimensioni { get; set; }
        public int NMarce { get; set; }

        protected Veicolo(string marca, string modello, int cilindrata, string classeInquinamento, bool isAutomatico, DateTime annoImmatricolazione, double prezzo, string alimentazione, List<string> optional, double potenza, int nPosti, string colore, string targa, int km, DimensioniStruct dimensioni, int nMarce)
        {
            Marca = marca;
            Modello = modello;
            Cilindrata = cilindrata;
            ClasseInquinamento = classeInquinamento;
            IsAutomatico = isAutomatico;
            AnnoImmatricolazione = annoImmatricolazione;
            Prezzo = prezzo;
            Alimentazione = alimentazione;
            Optional = optional;
            Potenza = potenza;
            NPosti = nPosti;
            Colore = colore;
            Targa = targa;
            Km = km;
            Dimensioni = dimensioni;
            NMarce = nMarce;
        }

        public override string ToString()
        {
            return Marca + " - " + Modello + " - " + AnnoImmatricolazione + " - " + Targa;
        }
    }
}
