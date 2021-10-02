using Caliburn.Micro;
using Laboration_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using System.Globalization;
using CsvHelper.Configuration;
using System.Collections.ObjectModel;

namespace Laboration_4.ViewModels
{
    public class ShellViewModel
    {
        public BindableCollection<PersonModel> People { get; set; }
        public ShellViewModel()
        {
            CsvManager csvManager = new();
            People = new BindableCollection<PersonModel>(csvManager.ReadCsv());
        }
    }
}
