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
                        ElencoVeicoli("\n*** Elenco Generale Veicoli ***");
                        break;
                    case '2':
                        ElencoVeicoli("\n*** Elenco AUTO ***", typeof(Auto));
                        break;
                    case '3':
                        ElencoVeicoli("\n*** Elenco MOTO ***", typeof(Moto));
                        break;
                    default:
                        break;
                }
            }
        }

        private static void ElencoVeicoli(string titolo, Type tipo = null)
        {
            Console.Clear();
            Console.WriteLine(titolo);
            int conta = 0;
            foreach (var item in ParcoMezzi)
            {
                if (tipo == null || tipo == item.GetType()) { 
                    conta++;
                    Console.WriteLine(conta.ToString() + " - " +  item.ToString(true));
                }
            }
            Console.WriteLine("\n");
        }

        private static char ScriviMenu()
        {
            Console.WriteLine("1 - Visualizza TUTTI i veicoli");
            Console.WriteLine("2 - Visualizza le AUTO");
            Console.WriteLine("3 - Visualizza le MOTO");
            Console.WriteLine("\nQ - USCITA");
            return Console.ReadKey(true).KeyChar;
        }

        static void CreaDatiDiProva()
        {
            Veicolo v = new Auto("BMW", "Serie 3", EAlimentazione.Benzina, "Blu");
            ParcoMezzi.Add(v);
            v = new Auto("Mercedes", "CLA", EAlimentazione.Diesel, "Grigio", true, 5, 18);
            ParcoMezzi.Add(v);
            v = new Moto("Yamaha", "KZ5", EAlimentazione.Benzina, "Verde", 
                "A34DE76PLYT90", 3500, 210,
                ETipoMoto.Enduro, 4,
                130, new DateTime(2021,03,15), 12750);
            ParcoMezzi.Add(v);
            v = new Moto("Ducati", "RossoFuoco", EAlimentazione.Benzina, "Rosso", ETipoMoto.Strada, 4);
            ParcoMezzi.Add(v);
            v = new Auto("Fiat", "500", EAlimentazione.Elettrica, "Bianco", 
                "TR5654ER55YJT5", 37500, 140,
                false, 3, 16,
                90, new DateTime(2021, 10, 13), 17500);
            ParcoMezzi.Add(v);
        }
    }
}
