using System;

namespace ThirdPartyLibraries
{
    class Program
    {
        static void Main(string[] args)
        {
            CsvHandler.ImplementCSVDataHandling();
            ReadCSVandWriteJSON.ImplementCSVToJSON();
        }
    }
}