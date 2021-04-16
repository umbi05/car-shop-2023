using System;
using System.Collections.Generic;
using System.Text;

namespace CarShopDLL
{
    public class Auto : Veicolo
    {
        public bool IsCabrio { get; set; }
        public bool IsPanoramica { get; set; }
        public bool IsSuperBollo { get; }
        public int DiametroCerchi { get; set; }
        public int NPorte { get; set; }
        public string Trazione { get; set; }
        public string Allestimento { get; set; }
        public bool HasFendinebbia { get; set; }

        public Auto(string marca, string modello, int cilindrata, string classeInquinamento, bool isAutomatico, DateTime annoImmatricolazione, double prezzo, string alimentazione, List<string> optional, double potenza, int nPosti, string colore, string targa, int km, int nMarce,
            bool isCabrio, bool isPanoramica, bool isSuperBollo, int diametroCerchi, int nPorte, string trazione, string allestimento, bool hasFendinebbia)
            : base(marca, modello, cilindrata, classeInquinamento, isAutomatico, annoImmatricolazione, prezzo, alimentazione, optional, potenza, nPosti, colore, targa, km, nMarce)
        {
            
            IsCabrio = isCabrio;
            IsPanoramica = isPanoramica;
            IsSuperBollo = isSuperBollo;
            DiametroCerchi = diametroCerchi;
            NPorte = nPorte;
            Trazione = trazione;
            Allestimento = allestimento;
            HasFendinebbia = hasFendinebbia;
        }

        public override string ToString()
        {
            //return base.ToString();
            string st = "Auto: " + Marca + " - " + Modello;
            if (IsCabrio)
            {
                st += " (cabrio) ";
            }
            st += NPosti + " posti " + " - Colore: " + Colore;
            return st;
        }
    }
}
