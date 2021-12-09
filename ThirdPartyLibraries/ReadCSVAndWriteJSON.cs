using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace ThirdPartyLibraries
{
    public class ReadCSVandWriteJSON
    {
        public static void ImplementCSVToJSON()
        {
            string importFilePath = @"C:\Users\navee\OneDrive\Documents\Bridgelabz practice\ThirdPartyLibraries\ThirdPartyLibraries\Files\JsonData.csv";
            string exportFilePath = @"C:\Users\navee\OneDrive\Documents\Bridgelabz practice\ThirdPartyLibraries\ThirdPartyLibraries\Files\export.json";
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data successfully from Json csv");
                foreach (AddressData addressData in records)
                {
                    Console.WriteLine(addressData.FirstName + "\t" + addressData.LastName + "\t" + addressData.City + "\t" + addressData.State + "\t" + addressData.Code + "\n");
                }
                Console.WriteLine("\n************  Now reading from csv file and write to Json file  ************");
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }
            }
        }
    }
}