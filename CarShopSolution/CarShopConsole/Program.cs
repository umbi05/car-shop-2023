using System;
using System.Collections.Generic;
using CarShopDLL;

namespace CarShopConsole
{
    class Program
    {
        static List<Veicolo> veicoli = new List<Veicolo>();
        static Veicolo v;

        static void Main(string[] args)
        {
            v = new Auto("Audi", "A3", 2000, "EURO 6", true, new DateTime(2019,10,01), 27.600, "Diesel", new List<string>(), 90, 5, "Nero", "GX321AB", 47300, new Veicolo.DimensioniStruct(445, 270 ,168), 8, false, false, false, 19, 5, "Integrale", "Business", true);
            veicoli.Add(v);
            v = new Auto("Alfa Romeo", "Giulia", 2143, "EURO 6", true, new DateTime(2018 / 05 / 29), 40.500, "Diesel", new List<string>(), 179, 5, "Blu", "EA781PQ", 50200, new Veicolo.DimensioniStruct(455, 290, 158), 6, true, true, false, 20, 5, "Integrale", "Standard", true);
            veicoli.Add(v);
            v = new Auto("BMW", "Serie 3", 2200, "EURO 5", false, new DateTime(2007, 04, 01), 30.000, "Benzina", new List<string>(), 100, 5, "Bianca", "MM846RT", 120000, new Veicolo.DimensioniStruct(500, 290, 150), 6, false, true, true, 50, 5, "posteriore", "business", false);
            veicoli.Add(v);

            v = new Moto("KTM", "EXC Six Days", 125, "Euro 5", false, new DateTime(2015, 04, 01), 7800, "Benzina", new List<string>(), 500, 2, "Blu", "ED451YY", 82750, new Veicolo.DimensioniStruct(120, 50, 78), 5, "Enduro", 4, "Sport", Avviamento.Automatico, false, "Pelle", true, true);
            veicoli.Add(v);
            v = new Moto("Kawasaki", "Ninja H2", 1000, "EURO 4", true, new DateTime(2019, 10, 01), 29.700, "Benzina", new List<string>(), 170, 2, "Nero", "GX321AB", 47300, new Veicolo.DimensioniStruct(84, 30, 47), 6, "stradale", 4, "hypersport", Avviamento.Automatico, false, "pelle", true, false);
            veicoli.Add(v);

            v = new Furgone("Fiat", "Ducato", 800, "EURO 5", false, new DateTime(2016, 06, 18), 12000, "Benzina", new List<string>(), 80, 3, "Bianco", "DA223WE", 40000, new Veicolo.DimensioniStruct(220, 252, 190), 5, 3000, 1115, "Furgonato");
            veicoli.Add(v);

            foreach (Veicolo veicolo in veicoli)
            {
                Console.WriteLine(veicolo);
            }

            string serializedData = Utils.SerializeToJson(veicoli);
            Console.WriteLine("\n\nSERIALIZZAZIONE JSON:\n" + serializedData);

            Console.ReadKey();
        }
    }
}
