using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopLibrary
{
    public class Auto : Veicolo
    {
        public Auto(string marca, string modello)
        {
            Marca = marca;
            Modello = modello;
        }
    }
}
