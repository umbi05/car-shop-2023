using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CarShopLibrary
{
    public enum ETipoMoto
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
        public ETipoMoto Tipo { get; set; }
        public int NumTempi { get; set; }

        public Moto(string marca, string modello, EAlimentazione alimentazione, string colore) 
            : base(marca, modello, alimentazione, colore) { }

        public Moto(string marca, string modello, EAlimentazione alimentazione, string colore, 
            ETipoMoto tipo, int numTempi) 
            : this(marca, modello, alimentazione, colore)
        {
            Tipo = tipo;
            NumTempi = numTempi;
        }

        /*
        public Moto(string marca, string modello, string vin,
            string colore, int km, EAlimentazione alimentazione, int maxSpeed,
            int potenza, DateTime dataImmatricolazione, int prezzo,
            ETipoMoto tipo, int numTempi)
            : this(marca, modello, tipo, numTempi)
        {
            VIN = vin;
            Colore = colore;
            Km = km;
            Alimentazione = alimentazione;
            MaxSpeed = maxSpeed;
            Potenza = potenza;
            DataImmatricolazione = dataImmatricolazione;
            Prezzo = prezzo;
        }
        */

        public Moto(string marca, string modello, string vin,
            string colore, int km, EAlimentazione alimentazione, int maxSpeed,
            int potenza, DateTime dataImmatricolazione, int prezzo,
            ETipoMoto tipo, int numTempi)
            : base(marca, modello, vin,colore,km,alimentazione,maxSpeed,potenza,dataImmatricolazione,prezzo)
        {
            Tipo = tipo;
            NumTempi = numTempi;
        }

        public override string ToString()
        {
            string stOut = base.ToString();
            if (Tipo != ETipoMoto.Undefined) stOut += " Tipo: " + Tipo;
            if (NumTempi > 0) stOut += " Num.Tempi: " + NumTempi;
            return stOut;
        }
    }
}
