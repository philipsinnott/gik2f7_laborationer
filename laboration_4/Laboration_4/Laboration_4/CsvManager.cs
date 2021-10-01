using CsvHelper;
using CsvHelper.Configuration;
using Laboration_4.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    public class CsvManager
    {
        public static void ReadCsv(List<PersonModel> persons)
        {
            //List<PersonModel> records = new List<PersonModel>();
            using (var streamReader = new StreamReader(@"C:\Users\Phili\source\repos\CsvHelperDEMO\CsvHelperDEMO\bin\Debug\net5.0\klasslista-21.csv"))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";"
                };

                using (var csvReader = new CsvReader(streamReader, config))
                {
                    persons = csvReader.GetRecords<PersonModel>().ToList();
                }
                //foreach (var record in records)
                //{
                //    Console.WriteLine($"{record.Username} | {record.FirstName} {record.LastName} | Mail: {record.Email}");
                //}
            }
        }

    }
}
