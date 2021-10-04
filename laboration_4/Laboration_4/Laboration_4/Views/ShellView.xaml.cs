using Caliburn.Micro;
using Laboration_4.Models;
using Laboration_4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Laboration_4.Views
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : Window
    {
        public BindableCollection<PersonModel> People { get; set; }
        CsvManager csvManager = new();
        public ShellView()
        {
            InitializeComponent();
        }

        private void loadList_Click(object sender, RoutedEventArgs e)
        {
            People = new BindableCollection<PersonModel>(csvManager.ReadCsv());
            myGrid.ItemsSource = People;
            loadList.IsEnabled = false;
        }
    }
}
