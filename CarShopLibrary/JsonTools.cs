using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace CarShopLibrary
{
    public class JsonTools
    {
        const string fileName = "parco-auto.json";

        public static bool SalvaDati(List<Veicolo> dati)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize<List<Veicolo>>(dati, options);
                // Console.WriteLine(jsonString);
                File.WriteAllText(fileName, jsonString);
                return true;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                return false;
            }
        }

        public static List<Veicolo> CaricaDati()
        {
            try
            {
                string jsonString = File.ReadAllText(fileName);
                return JsonSerializer.Deserialize<List<Veicolo>>(jsonString);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                return null;
            }
        }
        public static void creaHtml(Veicolo veicolo)
        {
            string html = $"<!DOCTYPE html>" +
                $" <html lang = 'en' xmlns = 'http://www.w3.org/1999/xhtml'>" +
                $" <head> " +
                $"<meta charset = 'utf-8' />" +
                $"<link rel = 'stylesheet' href = 'style.css' />" +
                $" <script src = 'https://code.jquery.com/jquery-3.6.1.min.js' integrity = 'sha256-o88AwQnZB+VDvE9tvIXrMQaPlFFSUTR+nldQm1LuPXQ=' crossorigin = 'anonymous' ></script >" +
                $" <script type = 'application/javascript' src = 'index.js' ></script > " +
                $" <title ></title >" +
                $"</head> " +
                $"<body >" +
                $"<h1 > FOR SALE </h1 >" +
                $"<img src = {veicolo.Immagine} />" +
                $"<div id = 'wrapper' >" +
                    $"<div class='container'>" +
                        $"<div class='txt'>" +
                            $"<p id = 'nome' >{veicolo.Marca} {veicolo.Modello}</p ><br />" +
                            $"<h2 > Colore: </h2> <p id = 'colore' >{veicolo.Colore}</p ><br />" +
                            $"<h2 > Dimensini: </h2><p id = 'Dimensioni' >Altezza: {veicolo.Dimensioni.altezza} Lunghezza: {veicolo.Dimensioni.lunghezza} Larghezza: {veicolo.Dimensioni.larghezza}</p ><br />" +
                            $"<h2 > Alimentazione: </h2><p id = 'alimentazione' >{veicolo.Alimentazione}</p ><br />" +
                            $"</div >" +
                        $"</div >" +
                    $"</div ></body >" +
                $"</html >";
            File.WriteAllText($"../../html/{veicolo.VIN}.html", html);
            Process.Start(AppDomain.CurrentDomain.BaseDirectory + $"../../html/{veicolo.VIN}.html");
        }
    }
}
