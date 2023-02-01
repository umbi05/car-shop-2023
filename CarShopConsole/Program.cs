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
            Console.ReadKey();
        }
    }
}
