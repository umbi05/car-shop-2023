using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using AngleSharp;
using AngleSharp.Dom;

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

        public static async void createHtml(List<Veicolo> veicoli, string templatePath, string outputPath)
        {
            string templateHtml = File.ReadAllText(templatePath);

            //Use the default configuration for AngleSharp
            var config = Configuration.Default;
            //Create a new context for evaluating webpages with the given config
            var context = BrowsingContext.New(config);
            //Create a virtual request to specify the document to load (here from our fixed string)
            var document = await context.OpenAsync(req => req.Content(templateHtml));

            // TODO: modificare il document
            var list = document.GetElementById("list");
            foreach (var veicolo in veicoli)
            {
                IElement newNode = (IElement)list.Clone(true);
                newNode.RemoveAttribute("id"); newNode.RemoveAttribute("*ngFor");
                list.Before(newNode);
            }
            list.Remove();

            File.WriteAllText(outputPath, document.DocumentElement.OuterHtml);
        }
    }
}
