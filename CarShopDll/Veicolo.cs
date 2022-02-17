using System;

namespace CarShopDll
{
    public abstract class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }

        public override string ToString()
        {
            return Marca + " " + Modello;
        }
    }

}
