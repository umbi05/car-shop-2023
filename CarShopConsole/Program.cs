using CarShopDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** RIVENDITA VEICOLI USATI ***");
            mostraVeicoli();
            Console.ReadKey();
        }

        private static void mostraVeicoli()
        {
            object v = new Auto("BMW", "Serie 3", true);
            Console.WriteLine(v.ToString());
            v = new Auto("Jeep", "Renegade", false);
            Console.WriteLine(v);
            v = new Auto("Mercedes", "CLA", new DateTime(2019, 10, 14), "Oceano", EAlimentazione.Diesel, ETrazione.Integrale, false);
            Console.WriteLine(v);
            v = new Auto("Peugeot", "208", new DateTime(2021, 6, 20), "Bianca", EAlimentazione.Elettrica, ETrazione.NonDichiarata, true);
            Console.WriteLine(v);
        }
    }
}
