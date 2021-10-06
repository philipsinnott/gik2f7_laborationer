using CsvHelper;
using CsvHelper.Configuration;
using Laboration4_NoFW.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4_NoFW
{
    public class CsvManager
    {
        public List<PersonModel> ReadCsv()
        {
            using (var streamReader = new StreamReader(@"klasslista-21.csv"))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";"
                };

                using (var csvReader = new CsvReader(streamReader, config))
                {
                    var people = csvReader.GetRecords<PersonModel>().ToList();
                    return people;
                }
            }
        }

        public void AppendToCsv(PersonModel added)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
                // Don't write the header again.
                HasHeaderRecord = false,
            };
            using (var stream = File.Open(@"klasslista-21.csv", FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, config))
            {
                // Go to next record so new students don't get added to same row
                csv.NextRecord();
                csv.WriteRecord(added);
            }
        }
    }
}
