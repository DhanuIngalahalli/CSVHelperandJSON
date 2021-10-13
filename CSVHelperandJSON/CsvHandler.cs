using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace CSVHelperandJson
{
    public class CSVHandler
    {
        public static void ImplementCSVDataHandling()
        {
            //setting path for import and export file
            string importFilePath = @"E:\BridgeLab\CSVHelperandJSON\CSVHelperandJSON\Utility\Address.csv";
            string exportFilePath = @"E:\BridgeLab\CSVHelperandJSON\CSVHelperandJSON\Utility\export.csv";

            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data successfully from addresses csv.");
                foreach (AddressData addressData in records)
                {
                    Console.Write("\t" + addressData.firstname);
                    Console.Write("\t" + addressData.lastname);
                    Console.Write("\t" + addressData.address);
                    Console.Write("\t" + addressData.city);
                    Console.Write("\t" + addressData.state);
                    Console.Write("\t" + addressData.code);
                    Console.WriteLine("\n");
                }
                Console.WriteLine("**********************Reading fromcsv file and Write to csv file **************************");
                using (var writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
        }
    }
}
