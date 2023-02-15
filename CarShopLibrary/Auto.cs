using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CarShopLibrary
{
    public class Auto : Veicolo
    {
        public bool IsAWD { get; set; }
        public int NumPorte { get; set; }
        public int DimCerchi { get; set; }

        public Auto() { }

        public Auto(string marca, string modello, EAlimentazione alimentazione, string colore)
            : base(marca, modello, alimentazione, colore) { }

        public Auto(string marca, string modello, EAlimentazione alimentazione, string colore,
            bool isAWD, int numPorte, int dimCerchi)
            : this(marca, modello, alimentazione, colore)
        {
            IsAWD = isAWD;
            NumPorte = numPorte;
            DimCerchi = dimCerchi;
        }

        public Auto(string marca, string modello, EAlimentazione alimentazione, string colore,
            StructDimensioni dimensioni, string vin, int km, int maxSpeed,
            int potenza, DateTime dataImmatricolazione, int prezzo, string immagine,
            bool isAWD, int numPorte, int dimCerchi
            )
            : base(marca, modello, alimentazione, colore, dimensioni, vin, km, maxSpeed, potenza, dataImmatricolazione, prezzo, immagine)
        {
            IsAWD = isAWD;
            NumPorte = numPorte;
            DimCerchi = dimCerchi;
        }

        public override string ToString()
        {
            string stOut = base.ToString();
            if (IsAWD) stOut += " INTEGRALE";
            if (NumPorte > 0) stOut += " Num.Porte: " + NumPorte;
            return stOut;
        }
    }
}
