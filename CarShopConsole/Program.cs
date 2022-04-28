using CarShopDll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsole
{
    class Program
    {
        static string PATHDATA = Directory.GetCurrentDirectory() + "\\veicoli.json";
        static BindingList<Veicolo> veicoli = new BindingList<Veicolo>();

        static void Main(string[] args)
        {
            char choice;
            do
            {
                Console.Clear();
                Console.WriteLine("*** RIVENDITA VEICOLI USATI ***");
                Console.WriteLine("1. Create test data");
                Console.WriteLine("2. Serialize to disk (veicoli.json)");
                Console.WriteLine("3. Load (deserialize) from disk");
                Console.WriteLine("4. Show data");
                Console.WriteLine("Q. QUIT");
                choice = Console.ReadKey(true).KeyChar;
                switch (choice)
                {
                    case '1': 
                        generateTestData();
                        break;
                    case '2':
                        serializeData();
                        break;
                    case '3':
                        deserializeData();
                        break;
                    case '4':
                        showData();
                        break;
                }
                Console.WriteLine("\n... press a key ...\n");
                Console.ReadKey(true);
            } while (char.ToUpper(choice) != 'Q');
        }

        private static void generateTestData()
        {
            Veicolo v;
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
            Console.WriteLine("\nData generated\n");
        }

        private static void serializeData()
        {
            Console.WriteLine("\n\nJSON SERIALIZATION:\n" + Tools.SerializeToJson(veicoli, PATHDATA));
            Console.WriteLine("\n\nFile created: " + PATHDATA);
        }

        private static void deserializeData()
        {
            veicoli = Tools.DeserializeFromFile(PATHDATA);
            Console.WriteLine("\n\nData loaded");
        }

        private static void showData()
        {
            Console.WriteLine("\n\nVEICOLI IN VENDITA:");
            foreach (var item in veicoli)
            {
                Console.WriteLine(item);
            }
        }
    }
}
