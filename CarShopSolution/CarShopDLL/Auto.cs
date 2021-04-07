using System;
using System.Collections.Generic;
using System.Text;

namespace CarShopDLL
{
    class Auto : Veicolo
    {
        public bool IsCabrio { get; set; }

        public Auto(string marca, string modello, bool isCabrio)
        {
            Marca = marca;
            Modello = modello;
            IsCabrio = isCabrio;
        }

        public override string ToString()
        {
            //return base.ToString();
            string st = Marca + " - " + Modello;
            if (IsCabrio)
            {
                st += " (cabrio)";
            }
            return st;
        }
    }
}
