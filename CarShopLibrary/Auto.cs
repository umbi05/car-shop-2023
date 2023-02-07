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

        public Auto(string marca, string modello) : base(marca, modello) { }

        public Auto(string marca, string modello, bool isAWD, int numPorte) : this(marca, modello)
        {
            IsAWD = isAWD;
            NumPorte = numPorte;
        }
    }
}
