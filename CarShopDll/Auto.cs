using System;
using System.Collections.Generic;
using System.Text;

namespace CarShopDll
{
    public enum ETrazione
    {
        NonDichiarata,
        Anteriore,
        Posteriore,
        Integrale
    }

    public class Auto : Veicolo
    {
        public bool IsCabrio { get; set; }
        public int DiametroCerchi { get; set; }
        public int NPorte { get; set; }
        public ETrazione Trazione { get; set; }
        public string Allestimento { get; set; }
        public bool HasFendinebbia { get; set; }

        public Auto() { }

        public Auto(string marca, string modello, bool pIsCabrio) : base(marca, modello)
        {
            IsCabrio = pIsCabrio;
        }

        public Auto(string marca, string modello, DateTime dataImmatricolazione,string colore, 
            EAlimentazione alimentazione, ETrazione trazione, bool pIsCabrio) : base(marca, modello)
        {
            DataImmatricolazione = dataImmatricolazione;
            Colore = colore;
            Alimentazione = alimentazione;
            Trazione = trazione;
            IsCabrio = pIsCabrio;
        }

        public Auto(string marca, string modello, int cilindrata,
            float potenza, DateTime dataImmatricolazione, int km,
            float peso, EAlimentazione alimentazione, bool isAutomatico,
            int nMarce, int classeInquinamento, int nPosti, string colore,
            string targa, List<string> optional, string descrizione,double prezzo,
            bool isCabrio, int diametroCerchi, int nPorte, 
            ETrazione trazione, string allestimento, bool hasFendinebbia)
            : base(marca, modello, cilindrata, potenza, dataImmatricolazione, km, peso, alimentazione, isAutomatico,
                  nMarce, classeInquinamento, nPosti, colore, targa, optional, descrizione, prezzo)
        {
            IsCabrio = isCabrio;
            DiametroCerchi = diametroCerchi;
            NPorte = nPorte;
            Trazione = trazione;
            Allestimento = allestimento;
            HasFendinebbia = hasFendinebbia;
        }

        public override string ToString()
        {
            string retVal = "Auto: " + base.ToString();
            string stCabrio = IsCabrio ? " CABRIO" : "";
            string stTrazione = Trazione != ETrazione.NonDichiarata ? " " + Trazione.ToString() : "";
            retVal += stTrazione + stCabrio;
            return retVal;
        }
    }
}
