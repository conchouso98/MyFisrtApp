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
            Simulate();
        }
        public static void Simulate()
        {
            List<CSV_Data> data = GetCSV_Datas().OrderBy(i => i.Fecha).ToList();
            double stockAmount = 0;
            for (int year = 2001; year <= 2017; year++)
            {

                for (int month = 1; month <= 12; month++)
                {
                    //Zara sale a bolsa en mayo de 2001
                    if (year == 2001 && month < 5)
                    {
                        continue;
                    }
                    int daysinmonth = DateTime.DaysInMonth(year,month);
                    List<DateTime> allthursday = new List<DateTime>();

                    for (int day = 1; day < daysinmonth; day++)
                    {
                        DateTime date = new DateTime(year, month, day);
                        if (date.DayOfWeek == DayOfWeek.Thursday)
                        {
                            allthursday.Add(date);
                        }
                    }

                    DateTime lastThursday = allthursday.Last();
                    CSV_Data buyData = data.Where(d => d.Fecha > lastThursday).FirstOrDefault();
                    if (buyData == null)                        
                    {
                        continue;
                    }
                    double stockstobuy = Math.Round((50d * 0.98d) / buyData.Apertura, 3);
                    Console.WriteLine("El dia " + allthursday.Last()   + " compro " + stockstobuy + " a " + buyData.Apertura);
                    stockAmount += stockstobuy;
                }
            }
            double totalCapital = stockAmount * data.Last().Cierre;
            Console.WriteLine(totalCapital);
        }
        public static List<CSV_Data> GetCSV_Datas()
        {
            var records = new List<CSV_Data>();
            var csvPath = Path.Combine(Environment.CurrentDirectory, $@"C:\Users\Holacons\Documents\FirstExam\stocks-ITX.csv");
            using (var streamReader = new StreamReader(csvPath))
            {
                CultureInfo culture = new CultureInfo("es-ES_tradnl");
                culture.NumberFormat.NumberDecimalSeparator = ".";
                var csvConfig = new CsvConfiguration(culture)
                {
                    Delimiter = ";"
                };
                using (var csvReader = new CsvReader(streamReader, csvConfig))
                {
                    //var records = csvReader.GetRecords<dynamic>().ToList();
                    records = csvReader.GetRecords<CSV_Data>().ToList();
                }
            }
            return records;

        }
        
    }
}
