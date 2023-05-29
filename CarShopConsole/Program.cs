﻿using CarShopLibrary;
using DocumentFormat.OpenXml.Packaging;
using Excel = DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarShopConsole
{
    class Program
    {
        const string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent quam augue, tempus id metus in, laoreet viverra quam. Sed vulputate risus lacus, et dapibus orci porttitor non.";

        //static IDataTools dataTools = new JsonTools();
        static IDataTools dataTools = new DbTools(AppDomain.CurrentDomain.BaseDirectory + "ParcoMezzi.mdf");
        static List<Veicolo> ParcoMezzi = new List<Veicolo>();
        static void Main(string[] args)
        {
            // CreaDatiDiProva();
            CaricaDati();
            char scelta = ' ';
            while (scelta.ToString().ToLower() != "q")
            {
                scelta = ScriviMenu();
                switch (scelta)
                {
                    case 'c':
                    case 'C':
                        CaricaDati();
                        break;
                    case 's':
                    case 'S':
                        SalvaDati();
                        break;
                    case '1':
                        ElencoVeicoli("\n*** Elenco Generale Veicoli ***");
                        break;
                    case '2':
                        ElencoVeicoli("\n*** Elenco AUTO ***", typeof(Auto));
                        break;
                    case '3':
                        ElencoVeicoli("\n*** Elenco MOTO ***", typeof(Moto));
                        break;
                    case 'h':
                    case 'H':
                        EsportaHtml();
                        break;
                    case 'w':
                    case 'W':
                        EsportaWord();
                        break;
                    case 'x':
                    case 'X':
                        EsportaExcel();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void EsportaHtml()
        {
            int num = 0;
            do
            {
                Console.Write("\nInserisci il numero d'ordine del veicolo: ");
            }
            while (!int.TryParse(Console.ReadLine(), out num));
            if (num > 0 && num < ParcoMezzi.Count)
            {
                Console.Clear();
                Console.WriteLine("\n" + ParcoMezzi[num - 1] + "\n");
                //Produrre volantino
                JsonTools.creaHtml(ParcoMezzi[num - 1]);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nErrore\n");
            }
        }
        
        private static void EsportaWord()
        {
            //int num = 0;
            //do
            //{
            //    Console.Write("\nInserisci il numero d'ordine del veicolo: ");
            //} while (!int.TryParse(Console.ReadLine(), out num));
            int num = 1;
            if (num > 0 && num < ParcoMezzi.Count)
            {
                Console.Clear();
                Console.WriteLine("\n" + ParcoMezzi[num - 1] + "\n");
                // Produrre volantino in word
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "/"+ParcoMezzi[num-1].VIN+".docx";
                OpenXmlTools.GeneraVolantinoDocx(filePath, ParcoMezzi[num - 1]);
                Process.Start(filePath);
                // Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nMezzo non esistente!\n");
            }
        }

        private static void EsportaExcel()
        {
            Console.Clear();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "/test.xlsx";
            GeneraReportXlsx(filePath);
            Process.Start(filePath);
        }
        public static void GeneraReportXlsx(string filePath)
        {
            SpreadsheetDocument reportDocument = OpenXmlExcelTools.CreaDocumento(filePath);
            using (reportDocument)
            {
                Excel.SheetData sheetData = OpenXmlExcelTools.getFirstSheetData(reportDocument);
                Excel.Row row = OpenXmlExcelTools.CreaRiga();
                row.Append(OpenXmlExcelTools.CreaCella("VOLANTINO VEICOLI IN VENDITA", true, false));
                sheetData.Append(row);
                row = OpenXmlExcelTools.CreaRiga(); sheetData.Append(row);  // riga vuota fra titolo e tabella
                string[] intestazione = { "VIN", "MARCA", "MODELLO", "DATA", "PREZZO" };
                row = OpenXmlExcelTools.CreaRiga(intestazione, true, true);
                sheetData.Append(row);
                foreach (Veicolo veicolo in ParcoMezzi)
                {
                    string[] datiRiga = { veicolo.VIN, veicolo.Marca, veicolo.Modello, veicolo.DataImmatricolazione.ToShortDateString(), veicolo.Prezzo.ToString() };
                    row = OpenXmlExcelTools.CreaRiga(datiRiga, false, true);
                    sheetData.Append(row);
                }
            }
        }
        private static void SalvaDati()
        {
            if (dataTools.SalvaDati(ParcoMezzi))
            {
                Console.WriteLine("\n*** SCRITTURA DATI OK ***");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        
        private static void CaricaDati()
        {
            ParcoMezzi = dataTools.CaricaDati();
            if (ParcoMezzi != null)
            {
                Console.WriteLine("\n*** CARICAMENTO DATI OK ***");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        private static void ElencoVeicoli(string titolo, Type tipo = null)
        {
            Console.Clear();
            Console.WriteLine(titolo);
            int conta = 0;
            foreach (var item in ParcoMezzi)
            {
                if (tipo == null || tipo == item.GetType()) { 
                    conta++;
                    Console.WriteLine(conta.ToString() + " - " +  item.ToString(true));
                }
            }
            Console.WriteLine("\n");
        }

        private static char ScriviMenu()
        {
            Console.WriteLine("*** GESTIONE RIVENDITA VEICOLI USATI ***");
            Console.WriteLine("".PadLeft(30, '_'));
            Console.WriteLine("C - CARICA Dati");
            Console.WriteLine("S - SALVA Dati");
            Console.WriteLine("".PadLeft(30, '_'));
            Console.WriteLine("1 - Visualizza TUTTI i veicoli");
            Console.WriteLine("2 - Visualizza le AUTO");
            Console.WriteLine("3 - Visualizza le MOTO");
            Console.WriteLine("".PadLeft(30, '_'));
            Console.WriteLine("H - Esporta Volatino HTML");
            Console.WriteLine("W - Esporta Volatino DOCX");
            Console.WriteLine("X - Esporta Volatino XLSX");
            Console.WriteLine("".PadLeft(30, '_'));
            Console.WriteLine("\nQ - USCITA");
            return Console.ReadKey(true).KeyChar;
        }

        static void CreaDatiDiProva()
        {
            Veicolo v = new Auto("BMW", "Serie 3", EAlimentazione.Benzina, "Blu");
            ParcoMezzi.Add(v);
            v = new Auto("Mercedes", "CLA", EAlimentazione.Diesel, "Grigio", true, 5, 18);
            ParcoMezzi.Add(v);
            v = new Moto("Yamaha", "KZ5", EAlimentazione.Benzina, "Verde", 
                new StructDimensioni(270,87,68), "A34DE76PLYT90", 3500, 210,
                130, new DateTime(2021, 03, 15), 12750, "",
                ETipoMoto.Enduro, 4);
            ParcoMezzi.Add(v);
            v = new Moto("Ducati", "RossoFuoco", EAlimentazione.Benzina, "Rosso", ETipoMoto.Strada, 4);
            ParcoMezzi.Add(v);
            v = new Auto("Fiat", "500", EAlimentazione.Elettrica, "Bianco",
                new StructDimensioni(320, 160, 140), "TR5654ER55YJT5", 37500, 140,
                90, new DateTime(2021, 10, 13), 17500, "",
                false, 3, 16);
            ParcoMezzi.Add(v);
        }
    }
}
