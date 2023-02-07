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
        static void Main(string[] args)
        {
            // Console.Write(ClsTest.HelloWorld("Oscar"));
            // Veicolo v = new Veicolo("BMW", "Serie 3");
            Veicolo v = new Auto("BMW", "Serie 3");
            Console.WriteLine("1° veicolo (auto): " + v.Marca + " " + v.Modello);
            Auto a = new Auto("Mercedes", "CLA", true, 5);
            Console.WriteLine("2° veicolo (auto): " + a.Marca + " " + a.Modello
                + (a.IsAWD ? " Integrale" : "") + " Num. Porte: " + a.NumPorte);
            v = new Moto("Yamaha", "KZ5");
            Console.WriteLine("3° veicolo (moto): " + v.Marca + " " + v.Modello);
            Moto m = new Moto("Ducati", "RossoFuoco", TipoMoto.Strada, 4);
            Console.WriteLine("4° veicolo (moto): " + m.Marca + " " + m.Modello
                + " " + m.Tipo + " Num. Tempi: " + m.NumTempi);
            Console.ReadKey();
        }
    }
}
