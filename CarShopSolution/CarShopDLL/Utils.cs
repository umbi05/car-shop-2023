using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace CarShopDLL
{
    public static class Utils
    {
        public static string SerializeToJson(List<Veicolo> veicoli, string filePath)
        {
            string serializedData = JsonConvert.SerializeObject(
                veicoli,
                new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto }
            );
            File.WriteAllText(filePath, serializedData);
            return serializedData;
        }

        public static List<Veicolo> DeserializeFromJson(string filePath)
        {
            string dataFromFile = File.ReadAllText(filePath);
            List<Veicolo> veicoli = JsonConvert.DeserializeObject<List<Veicolo>>(
                dataFromFile,
                new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto }
            );
            return veicoli;
        }
    }
}
