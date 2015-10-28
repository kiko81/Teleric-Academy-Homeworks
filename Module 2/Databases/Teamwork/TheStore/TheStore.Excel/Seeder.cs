namespace TheStore.Excel
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;
    using System.Security.Policy;

    using Bytescout.Spreadsheet;

    public class Seeder
    {
        public void Seed(string townName, DateTime date, string rootFolder, IEnumerable<SalesInfo> products)
        {
            Spreadsheet document = new Spreadsheet();
            Worksheet sheet = document.Workbook.Worksheets.Add("SalesReport");

            sheet.Cell(0, 0).Value = "Product";
            sheet.Columns[0].Width = 250;

            sheet.Cell(0, 1).Value = "Price";
            sheet.Columns[1].Width = 250;

            sheet.Cell(0, 2).Value = "Quantity";
            sheet.Columns[2].Width = 250;

            sheet.Cell(0, 3).Value = "Sum";
            sheet.Columns[3].Width = 250;

            var rowNumber = 1;

            foreach (var product in products)
            {
                sheet.Cell(rowNumber, 0).Value = product.ProductId;
                sheet.Cell(rowNumber, 1).Value = product.Price;
                sheet.Cell(rowNumber, 2).Value = product.Quantity;
                sheet.Cell(rowNumber, 3).Value = product.Sum;

                ++rowNumber;
            }

            sheet.Range(rowNumber, 0, rowNumber, 3).Merge();
            sheet.Range(rowNumber, 0, rowNumber, 3).Value = products.Sum(x => x.Sum);

            var folderName = rootFolder + date.ToString("yyyy MMM dd");
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }

            var fileName = townName + ".xls";
            var filePath = folderName + "/" + fileName;

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            document.SaveAs(filePath);
           
            document.Close();
        }

        public void SendToZip(string rootFolder, string zipPath)
        {
            if (File.Exists(zipPath))
            {
                File.Delete(zipPath);
            }

            ZipFile.CreateFromDirectory(rootFolder, zipPath);
        }

        public void Unzip(string zipPath, string exportFolder)
        {
            if (Directory.Exists(exportFolder))
            {
                Directory.Delete(exportFolder, true);
            }

            Directory.CreateDirectory(exportFolder);

            ZipFile.ExtractToDirectory(zipPath, exportFolder + Path.GetFileNameWithoutExtension(zipPath));
        }
    }
}