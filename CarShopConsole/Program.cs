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
        static List<Veicolo> veicoli = new List<Veicolo>();
        static Veicolo v;

        static void Main(string[] args)
        {
            Console.WriteLine("*** RIVENDITA VEICOLI USATI ***");
            caricaVeicoli();
            mostraVeicoli();
            Console.WriteLine(Tools.SerializeToJson(veicoli));
            Console.ReadKey();
        }

        private static void caricaVeicoli()
        {
            v = new Auto("BMW", "Serie 3", true);
            veicoli.Add(v);
            v = new Auto("Jeep", "Renegade", false);
            veicoli.Add(v);
            v = new Auto("Mercedes", "CLA", new DateTime(2019, 10, 14), "Oceano", EAlimentazione.Diesel, ETrazione.Integrale, false);
            veicoli.Add(v);
            v = new Auto("Peugeot", "208", new DateTime(2021, 6, 20), "Bianca", EAlimentazione.Elettrica, ETrazione.NonDichiarata, true);
            veicoli.Add(v);
            v = new Moto("Yamaha", "NMAX", ETipoMoto.Enduro, 4, true);
            veicoli.Add(v);
            v = new Moto("Fantic", "Caballero", ETipoMoto.Trial, 2, false);
            veicoli.Add(v);
        }

        private static void mostraVeicoli()
        {
            foreach (var item in veicoli)
            {
                Console.WriteLine(item);
            }
        }
    }
}
