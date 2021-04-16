using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CarShopDLL
{
    public static class Utils
    {
        public static string SerializeToJson(List<Veicolo> veicoli)
        {
            return JsonConvert.SerializeObject(veicoli);
        }
    }
}
