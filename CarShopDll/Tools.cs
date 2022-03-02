using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CarShopDll
{
    public static class Tools
    {
        static JsonSerializerSettings jsonSettings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
       
        public static string SerializeToJson(List<Veicolo> veicoli, string filePath = null)
        {
            string serializedData = JsonConvert.SerializeObject(veicoli, jsonSettings);
                
            if (filePath != null)
            {
                File.WriteAllText(filePath, serializedData);
            }
            return serializedData;
        }

        public static List<Veicolo> DeserializeFromJson(string json)
        {
            return JsonConvert.DeserializeObject<List<Veicolo>>(json, jsonSettings);
        }

        public static List<Veicolo> DeserializeFromFile(string filePath)
        {
            string dataFromFile = File.ReadAllText(filePath);
            return DeserializeFromJson(dataFromFile);
        }
    }
}
