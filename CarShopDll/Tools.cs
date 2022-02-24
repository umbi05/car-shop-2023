using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarShopDll
{
    public static class Tools
    {
        public static string SerializeToJson(List<Veicolo> veicoli)
        {
            return JsonConvert.SerializeObject(veicoli);
        }
    }
}
