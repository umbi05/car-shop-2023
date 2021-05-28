using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Reflection;

using Newtonsoft.Json;

using AngleSharp;
using AngleSharp.Dom;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using Word = DocumentFormat.OpenXml.Wordprocessing;
using Excel = DocumentFormat.OpenXml.Spreadsheet;
using X14 = DocumentFormat.OpenXml.Office2010.Excel;
using X15 = DocumentFormat.OpenXml.Office2013.Excel;
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
            Process.Start(outputPath);
        }

        public static void CreateDocx(List<Veicolo> veicoli, string outputPath)
        {
            // Create a document by supplying the filepath. 
            using (WordprocessingDocument wordDocument =
            WordprocessingDocument.Create(outputPath, WordprocessingDocumentType.Document))
            {
                // Add a main document part. 
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                // Create the document structure and add some text.
                mainPart.Document = new Word.Document();
                Word.Body body = mainPart.Document.AppendChild(new Word.Body());
                foreach (var veicolo in veicoli)
                {
                    Word.Paragraph para = body.AppendChild(new Word.Paragraph());
                    PropertyInfo[] properties = veicolo.GetType().GetProperties();
                    foreach (PropertyInfo property in properties)
                    {
                        Word.Run run = para.AppendChild(new Word.Run());
                        Word.RunProperties runProp = new Word.RunProperties();
                        if (property.Name.ToLower() == "marca")
                        {
                            runProp.Bold = new Word.Bold();
                        }
                        run.Append(runProp);
                        run.AppendChild(new Word.Text(property.Name + ": " + property.GetValue(veicolo) + " - ") { Space = SpaceProcessingModeValues.Preserve });
                    }
                }
                Process.Start(outputPath);
            }
        }

        public static string CreateXlsx(List<Veicolo> veicoli, string outputPath)
        {
            var datetime = DateTime.Now.ToString().Replace("/", "_").Replace(":", "_");
            if (File.Exists(outputPath))
            {
                outputPath = Path.GetFileNameWithoutExtension(outputPath) + "_" + datetime + ".xlsx";
            }
            using (SpreadsheetDocument package = SpreadsheetDocument.Create(outputPath, SpreadsheetDocumentType.Workbook))
            {
                CreatePartsForExcel(package, veicoli);
            }
            return outputPath;
        }

        private static void CreatePartsForExcel(SpreadsheetDocument package, List<Veicolo> veicoli)
        {
            Excel.SheetData partSheetData = GenerateSheetdataForDetails(veicoli);

            WorkbookPart workbookPart1 = package.AddWorkbookPart();
            GenerateWorkbookPartContent(workbookPart1);

            WorkbookStylesPart workbookStylesPart1 = workbookPart1.AddNewPart<WorkbookStylesPart>("rId3");
            GenerateWorkbookStylesPartContent(workbookStylesPart1);

            WorksheetPart worksheetPart1 = workbookPart1.AddNewPart<WorksheetPart>("rId1");
            GenerateWorksheetPartContent(worksheetPart1, partSheetData);
        }

        private static void GenerateWorkbookPartContent(WorkbookPart workbookPart1)
        {
            Excel.Workbook workbook1 = new Excel.Workbook();
            Excel.Sheets sheets1 = new Excel.Sheets();
            Excel.Sheet sheet1 = new Excel.Sheet() { Name = "Veicoli", SheetId = (UInt32Value)1U, Id = "rId1" };
            sheets1.Append(sheet1);
            workbook1.Append(sheets1);
            workbookPart1.Workbook = workbook1;
        }

        private static void GenerateWorksheetPartContent(WorksheetPart worksheetPart1, Excel.SheetData sheetData1)
        {
            Excel.Worksheet worksheet1 = new Excel.Worksheet() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "x14ac" } };
            worksheet1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            worksheet1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            worksheet1.AddNamespaceDeclaration("x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");
            Excel.SheetDimension sheetDimension1 = new Excel.SheetDimension() { Reference = "A1" };

            Excel.SheetViews sheetViews1 = new Excel.SheetViews();

            Excel.SheetView sheetView1 = new Excel.SheetView() { TabSelected = true, WorkbookViewId = (UInt32Value)0U };
            Excel.Selection selection1 = new Excel.Selection() { ActiveCell = "A1", SequenceOfReferences = new ListValue<StringValue>() { InnerText = "A1" } };

            sheetView1.Append(selection1);

            sheetViews1.Append(sheetView1);
            Excel.SheetFormatProperties sheetFormatProperties1 = new Excel.SheetFormatProperties() { DefaultRowHeight = 15D, DyDescent = 0.25D };

            Excel.PageMargins pageMargins1 = new Excel.PageMargins() { Left = 0.7D, Right = 0.7D, Top = 0.75D, Bottom = 0.75D, Header = 0.3D, Footer = 0.3D };
            worksheet1.Append(sheetDimension1);
            worksheet1.Append(sheetViews1);
            worksheet1.Append(sheetFormatProperties1);
            worksheet1.Append(sheetData1);
            worksheet1.Append(pageMargins1);
            worksheetPart1.Worksheet = worksheet1;
        }

        private static void GenerateWorkbookStylesPartContent(WorkbookStylesPart workbookStylesPart1)
        {
            Excel.Stylesheet stylesheet1 = new Excel.Stylesheet() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "x14ac" } };
            stylesheet1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            stylesheet1.AddNamespaceDeclaration("x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");

            Excel.Fonts fonts1 = new Excel.Fonts() { Count = (UInt32Value)2U, KnownFonts = true };

            Excel.Font font1 = new Excel.Font();
            Excel.FontSize fontSize1 = new Excel.FontSize() { Val = 11D };
            Excel.Color color1 = new Excel.Color() { Theme = (UInt32Value)1U };
            Excel.FontName fontName1 = new Excel.FontName() { Val = "Calibri" };
            Excel.FontFamilyNumbering fontFamilyNumbering1 = new Excel.FontFamilyNumbering() { Val = 2 };
            Excel.FontScheme fontScheme1 = new Excel.FontScheme() { Val = Excel.FontSchemeValues.Minor };

            font1.Append(fontSize1);
            font1.Append(color1);
            font1.Append(fontName1);
            font1.Append(fontFamilyNumbering1);
            font1.Append(fontScheme1);

            Excel.Font font2 = new Excel.Font();
            Excel.Bold bold1 = new Excel.Bold();
            Excel.FontSize fontSize2 = new Excel.FontSize() { Val = 11D };
            Excel.Color color2 = new Excel.Color() { Theme = (UInt32Value)1U };
            Excel.FontName fontName2 = new Excel.FontName() { Val = "Calibri" };
            Excel.FontFamilyNumbering fontFamilyNumbering2 = new Excel.FontFamilyNumbering() { Val = 2 };
            Excel.FontScheme fontScheme2 = new Excel.FontScheme() { Val = Excel.FontSchemeValues.Minor };

            font2.Append(bold1);
            font2.Append(fontSize2);
            font2.Append(color2);
            font2.Append(fontName2);
            font2.Append(fontFamilyNumbering2);
            font2.Append(fontScheme2);

            fonts1.Append(font1);
            fonts1.Append(font2);

            Excel.Fills fills1 = new Excel.Fills() { Count = (UInt32Value)2U };

            Excel.Fill fill1 = new Excel.Fill();
            Excel.PatternFill patternFill1 = new Excel.PatternFill() { PatternType = Excel.PatternValues.None };

            fill1.Append(patternFill1);

            Excel.Fill fill2 = new Excel.Fill();
            Excel.PatternFill patternFill2 = new Excel.PatternFill() { PatternType = Excel.PatternValues.Gray125 };

            fill2.Append(patternFill2);

            fills1.Append(fill1);
            fills1.Append(fill2);

            Excel.Borders borders1 = new Excel.Borders() { Count = (UInt32Value)2U };

            Excel.Border border1 = new Excel.Border();
            Excel.LeftBorder leftBorder1 = new Excel.LeftBorder();
            Excel.RightBorder rightBorder1 = new Excel.RightBorder();
            Excel.TopBorder topBorder1 = new Excel.TopBorder();
            Excel.BottomBorder bottomBorder1 = new Excel.BottomBorder();
            Excel.DiagonalBorder diagonalBorder1 = new Excel.DiagonalBorder();

            border1.Append(leftBorder1);
            border1.Append(rightBorder1);
            border1.Append(topBorder1);
            border1.Append(bottomBorder1);
            border1.Append(diagonalBorder1);

            Excel.Border border2 = new Excel.Border();

            Excel.LeftBorder leftBorder2 = new Excel.LeftBorder() { Style = Excel.BorderStyleValues.Thin };
            Excel.Color color3 = new Excel.Color() { Indexed = (UInt32Value)64U };

            leftBorder2.Append(color3);

            Excel.RightBorder rightBorder2 = new Excel.RightBorder() { Style = Excel.BorderStyleValues.Thin };
            Excel.Color color4 = new Excel.Color() { Indexed = (UInt32Value)64U };

            rightBorder2.Append(color4);

            Excel.TopBorder topBorder2 = new Excel.TopBorder() { Style = Excel.BorderStyleValues.Thin };
            Excel.Color color5 = new Excel.Color() { Indexed = (UInt32Value)64U };

            topBorder2.Append(color5);

            Excel.BottomBorder bottomBorder2 = new Excel.BottomBorder() { Style = Excel.BorderStyleValues.Thin };
            Excel.Color color6 = new Excel.Color() { Indexed = (UInt32Value)64U };

            bottomBorder2.Append(color6);
            Excel.DiagonalBorder diagonalBorder2 = new Excel.DiagonalBorder();

            border2.Append(leftBorder2);
            border2.Append(rightBorder2);
            border2.Append(topBorder2);
            border2.Append(bottomBorder2);
            border2.Append(diagonalBorder2);

            borders1.Append(border1);
            borders1.Append(border2);

            Excel.CellStyleFormats cellStyleFormats1 = new Excel.CellStyleFormats() { Count = (UInt32Value)1U };
            Excel.CellFormat cellFormat1 = new Excel.CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U };

            cellStyleFormats1.Append(cellFormat1);

            Excel.CellFormats cellFormats1 = new Excel.CellFormats() { Count = (UInt32Value)3U };
            Excel.CellFormat cellFormat2 = new Excel.CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U };
            Excel.CellFormat cellFormat3 = new Excel.CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyBorder = true };
            Excel.CellFormat cellFormat4 = new Excel.CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true };

            cellFormats1.Append(cellFormat2);
            cellFormats1.Append(cellFormat3);
            cellFormats1.Append(cellFormat4);

            Excel.CellStyles cellStyles1 = new Excel.CellStyles() { Count = (UInt32Value)1U };
            Excel.CellStyle cellStyle1 = new Excel.CellStyle() { Name = "Normal", FormatId = (UInt32Value)0U, BuiltinId = (UInt32Value)0U };

            cellStyles1.Append(cellStyle1);
            Excel.DifferentialFormats differentialFormats1 = new Excel.DifferentialFormats() { Count = (UInt32Value)0U };
            Excel.TableStyles tableStyles1 = new Excel.TableStyles() { Count = (UInt32Value)0U, DefaultTableStyle = "TableStyleMedium2", DefaultPivotStyle = "PivotStyleLight16" };

            Excel.StylesheetExtensionList stylesheetExtensionList1 = new Excel.StylesheetExtensionList();

            Excel.StylesheetExtension stylesheetExtension1 = new Excel.StylesheetExtension() { Uri = "{EB79DEF2-80B8-43e5-95BD-54CBDDF9020C}" };
            stylesheetExtension1.AddNamespaceDeclaration("x14", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main");
            X14.SlicerStyles slicerStyles1 = new X14.SlicerStyles() { DefaultSlicerStyle = "SlicerStyleLight1" };

            stylesheetExtension1.Append(slicerStyles1);

            Excel.StylesheetExtension stylesheetExtension2 = new Excel.StylesheetExtension() { Uri = "{9260A510-F301-46a8-8635-F512D64BE5F5}" };
            stylesheetExtension2.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");
            X15.TimelineStyles timelineStyles1 = new X15.TimelineStyles() { DefaultTimelineStyle = "TimeSlicerStyleLight1" };

            stylesheetExtension2.Append(timelineStyles1);

            stylesheetExtensionList1.Append(stylesheetExtension1);
            stylesheetExtensionList1.Append(stylesheetExtension2);

            stylesheet1.Append(fonts1);
            stylesheet1.Append(fills1);
            stylesheet1.Append(borders1);
            stylesheet1.Append(cellStyleFormats1);
            stylesheet1.Append(cellFormats1);
            stylesheet1.Append(cellStyles1);
            stylesheet1.Append(differentialFormats1);
            stylesheet1.Append(tableStyles1);
            stylesheet1.Append(stylesheetExtensionList1);

            workbookStylesPart1.Stylesheet = stylesheet1;
        }

        private static Excel.SheetData GenerateSheetdataForDetails(List<Veicolo> veicoli)
        {
            Excel.SheetData sheetData1 = new Excel.SheetData();
            sheetData1.Append(CreateHeaderRowForExcel());

            foreach (Veicolo v in veicoli)
            {
                Excel.Row partsRows = GenerateRowForChildPartDetail(v);
                sheetData1.Append(partsRows);
            }
            return sheetData1;
        }

        private static Excel.Row CreateHeaderRowForExcel()
        {
            Excel.Row workRow = new Excel.Row();
            workRow.Append(CreateCell("Tipo", 2U));
            workRow.Append(CreateCell("Marca", 2U));
            workRow.Append(CreateCell("Modello", 2U));
            workRow.Append(CreateCell("Targa", 2U));
            workRow.Append(CreateCell("Anno", 2U));
            workRow.Append(CreateCell("Prezzo", 2U));
            return workRow;
        }

        private static Excel.Row GenerateRowForChildPartDetail(Veicolo veicolo)
        {
            Excel.Row tRow = new Excel.Row();
            tRow.Append(CreateCell(veicolo.GetType().Name.ToString()));
            tRow.Append(CreateCell(veicolo.Marca));
            tRow.Append(CreateCell(veicolo.Modello));
            tRow.Append(CreateCell(veicolo.Targa));
            tRow.Append(CreateCell(veicolo.AnnoImmatricolazione.Year.ToString()));
            tRow.Append(CreateCell(veicolo.Prezzo.ToString()));
            return tRow;
        }

        private static Excel.Cell CreateCell(string text, uint styleIndex = 1U)
        {
            Excel.Cell cell = new Excel.Cell();
            cell.StyleIndex = styleIndex;
            cell.DataType = ResolveCellDataTypeOnValue(text);
            cell.CellValue = new Excel.CellValue(text);
            return cell;
        }

        private static EnumValue<Excel.CellValues> ResolveCellDataTypeOnValue(string text)
        {
            int intVal;
            double doubleVal;
            if (int.TryParse(text, out intVal) || double.TryParse(text, out doubleVal))
            {
                return Excel.CellValues.Number;
            }
            else
            {
                return Excel.CellValues.String;
            }
        }
    }
}
