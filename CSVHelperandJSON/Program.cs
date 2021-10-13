using System;

namespace CSVHelperandJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#Read Data from CSV and Write Data in CSV");
            CSVHandler.ImplementCSVDataHandling();
            Console.WriteLine();

            Console.WriteLine("#Read Data from CSV and Write Data in Json");
            ReadCSV_And_WriteJSON.ImplementCSVToJSON();
            Console.WriteLine();

            Console.WriteLine("#Read Data from json and Write Data in CSV");
            ReadJSONWriteCSV.ImplementJSONToCSV();
            Console.WriteLine();

        }
    }
}