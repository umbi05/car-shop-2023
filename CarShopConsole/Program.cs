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
        }
    }
}
