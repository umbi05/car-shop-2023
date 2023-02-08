using CarShopLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsole
{
    class Program
    {
        static List<Veicolo> ParcoMezzi = new List<Veicolo>();

        static void Main(string[] args)
        {
            CreaDatiDiProva();
            Console.WriteLine("*** GESTIONE RIVENDITA VEICOLI USATI ***");
            char scelta = ' ';
            while (scelta.ToString().ToLower() != "q")
            {
                scelta = ScriviMenu();
                switch (scelta)
                {
                    case '1':
                        ElencoVeicoli();
                        break;
                    case '2':
                        ElencoSoloAuto();
                        break;
                    case '3':
                        ElencoSoloMoto();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void ElencoSoloMoto()
        {
            Console.Clear();
            Console.WriteLine("\n*** Elenco MOTO ***");
            int conta = 0;
            foreach (var item in ParcoMezzi)
            {
                if (item is Moto)
                {
                    conta++;
                    Console.WriteLine(conta.ToString() + " - " + item.ToString(true));
                }
            }
            Console.WriteLine("\n");
        }

        private static void ElencoSoloAuto()
        {
            Console.Clear();
            Console.WriteLine("\n*** Elenco AUTO ***");
            int conta = 0;
            foreach (var item in ParcoMezzi)
            {
                if (item is Auto)
                {
                    conta++;
                    Console.WriteLine(conta.ToString() + " - " + item.ToString(true));
                }
            }
            Console.WriteLine("\n");
        }

        private static void ElencoVeicoli()
        {
            Console.Clear();
            Console.WriteLine("\n*** Elenco Generale Veicoli ***");
            int conta = 0;
            foreach (var item in ParcoMezzi)
            {
                conta++;
                Console.WriteLine(conta.ToString() + " - " +  item.ToString());
            }
            Console.WriteLine("\n");
        }

        private static char ScriviMenu()
        {
            Console.WriteLine("1 - Visualizza TUTTI i veicoli");
            Console.WriteLine("2 - Visualizza le AUTO");
            Console.WriteLine("1 - Visualizza le MOTO");
            Console.WriteLine("\nQ - USCITA");
            return Console.ReadKey(true).KeyChar;
        }

        static void CreaDatiDiProva()
        {
            Veicolo v = new Auto("BMW", "Serie 3", EAlimentazione.Benzina, "Blu");
            ParcoMezzi.Add(v);
            v = new Auto("Mercedes", "CLA", EAlimentazione.Diesel, "Grigio", true, 5, 18);
            ParcoMezzi.Add(v);
            v = new Moto("Yamaha", "KZ5", EAlimentazione.Benzina, "Verde");
            ParcoMezzi.Add(v);
            v = new Moto("Ducati", "RossoFuoco", EAlimentazione.Benzina, "Rosso", ETipoMoto.Strada, 4);
            ParcoMezzi.Add(v);
            v = new Auto("Fiat", "500", "TR5654ER55YJT5", "Bianco", 37500, EAlimentazione.Elettrica,
                140, 90, new DateTime(2021, 10, 13), 17500, false, 3, 16);
            ParcoMezzi.Add(v);
        }
    }
}
