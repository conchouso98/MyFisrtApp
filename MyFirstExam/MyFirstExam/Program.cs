using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;




namespace MyFirstExam
{
    static class Program
    {
        static void Main()
        {
            var csvPath = Path.Combine(Environment.CurrentDirectory, $@"C:\Users\Holacons\Documents\FirstExam\stocks-ITX.csv");
            using (var streamReader = new StreamReader(csvPath))
            {
                var csvConfig = new CsvConfiguration(new CultureInfo("es-ES_tradnl"))
                {
                    Delimiter = ";"
                };
                using (var csvReader = new CsvReader(streamReader, csvConfig))
                {
                    //var records = csvReader.GetRecords<dynamic>().ToList();
                    var records = csvReader.GetRecords<CSV_Data>().ToList();
                }
            }

        }
    }
}
