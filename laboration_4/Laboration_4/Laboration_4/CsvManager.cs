using Caliburn.Micro;
using CsvHelper;
using CsvHelper.Configuration;
using Laboration_4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    public class CsvManager
    {
        public List<PersonModel> ReadCsv()
        {
            List<PersonModel> people = new List<PersonModel>();
            using (var streamReader = new StreamReader(@"klasslista-21.csv"))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";"
                };

                using (var csvReader = new CsvReader(streamReader, config))
                {
                    people = csvReader.GetRecords<PersonModel>().ToList();
                }
                return people;
            }
        }
        public void WriteToCsv(List<PersonModel> people)
        {
            using (var writer = new StreamWriter(@"klasslista-21.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(people);
            }
        }
    }
}
