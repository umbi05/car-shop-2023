using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CarShopLibrary
{
    public enum TipoMoto
    {
        Undefined,
        Cross,
        Enduro,
        Strada,
        Chopper,
        Touring
    }

    public class Moto : Veicolo
    {
        public TipoMoto Tipo { get; set; }
        public int NumTempi { get; set; }

        public Moto(string marca, string modello) : base(marca, modello) { }

        public Moto(string marca, string modello, TipoMoto tipo, int numTempi) : this(marca, modello)
        {
            Tipo = tipo;
            NumTempi = numTempi;
        }

        public override string ToString()
        {
            string stOut = base.ToString();
            if (Tipo != TipoMoto.Undefined) stOut += " Tipo: " + Tipo;
            if (NumTempi > 0) stOut += " Num.Tempi: " + NumTempi;
            return stOut;
        }
    }
}
