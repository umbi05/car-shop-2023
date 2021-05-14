using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using AngleSharp;
using AngleSharp.Dom;
using System.Reflection;
using System;

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

            var list = document.GetElementById("list");
            foreach (var veicolo in veicoli)
            {
                IElement newNode = (IElement)list.Clone(true);
                PropertyInfo[] properties = veicolo.GetType().GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    //Console.WriteLine(property.Name);
                    IElement propertyNode = newNode.QuerySelector('#' + property.Name.ToLower());
                    if (propertyNode != null)
                    {
                        propertyNode.TextContent = property.GetValue(veicolo).ToString();
                        propertyNode.RemoveAttribute("id");
                    }
                }
                newNode.RemoveAttribute("id");
                IElement imageEl = newNode.QuerySelector("#immagine");
                imageEl.SetAttribute("src", "images/" + veicolo.Targa + ".jpg");
                list.Before(newNode);
            }
            list.Remove();

            File.WriteAllText(outputPath, document.DocumentElement.OuterHtml);
        }
    }
}
