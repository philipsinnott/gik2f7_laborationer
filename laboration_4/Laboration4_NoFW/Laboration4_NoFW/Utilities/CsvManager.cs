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
using System.Windows;

namespace Laboration4_NoFW
{
    public class CsvManager
    {
        public List<PersonModel> ReadCsv(string path)
        {
            try
            {
                using (var streamReader = new StreamReader(path))
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
            catch (IOException ex)
            {
                MessageBox.Show("Invalid file.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                throw ex;
            }
        }

        public async void AppendToCsv(PersonModel added)
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
                await csv.NextRecordAsync();
            }
        }
    }
}
