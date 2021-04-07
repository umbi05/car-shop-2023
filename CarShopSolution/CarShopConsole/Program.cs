using System;
using CarShopDLL;

namespace CarShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a = new Auto("BMW", "Serie 3", true);
            Console.WriteLine(a.ToString());
            Console.ReadKey();
        }
    }
}
