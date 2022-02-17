using System;
using System.Collections.Generic;
using System.Text;

namespace CarShopDll
{
    public class Auto: Veicolo
    {
        public bool IsCabrio { get; set; }

        public Auto(string pMarca, string pModello, bool pIsCabrio)
        {
            Marca = pMarca;
            Modello = pModello;
            IsCabrio = pIsCabrio;
        }

        public override string ToString()
        {
            string stCabrio = IsCabrio ? " CABRIO" : " NO CABRIO";
            return base.ToString() + stCabrio   ;
        }
    }
}
