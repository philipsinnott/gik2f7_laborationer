using Laboration4_NoFW.Logic;
using Laboration4_NoFW.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laboration4_NoFW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<PersonModel> People = new();
        CsvManager csvManager = new();
        InfoGenerator infoGen = new();
        Validator validator = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadList_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = @"c:\temp\";
            if (openFileDialog.ShowDialog() == true)
            {
                People = csvManager.ReadCsv(openFileDialog.FileName);
                lstNamesDb.ItemsSource = People;
            }
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            PersonModel addedPerson = new PersonModel() { Username = infoGen.UsernameGenerator(addUserFirstNameText.Text, addUserLastNameText.Text), FirstName = addUserFirstNameText.Text, LastName = addUserLastNameText.Text, Email = addUserEmailText.Text };
            if (validator.ValidateField(addedPerson.FirstName) == true && validator.ValidateField(addedPerson.LastName) == true && validator.ValidateField(addedPerson.Email) == true)
            {
                People.Add(addedPerson);
                csvManager.AppendToCsv(addedPerson);
                lstNamesDb.Items.Refresh();
                MessageBox.Show($"{addedPerson.FirstName} {addedPerson.LastName} ({addedPerson.Username}) added to the list.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                People.Remove(addedPerson);
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void LstNamesDb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            var index = listBox.SelectedIndex;

            // Set index
            ListBoxItem row = listBox.ItemContainerGenerator.ContainerFromIndex(index) as ListBoxItem;

            // Get data behind row
            PersonModel item = (PersonModel)listBox.ItemContainerGenerator.ItemFromContainer(row);

            // Insert selected values into textboxes
            firstNameText.Text = item.FirstName.ToString();
            lastNameText.Text = item.LastName.ToString();
            emailText.Text = item.Email.ToString();
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            while (lstNamesDb.SelectedItems.Count > 0)
            {
                lstNamesDb.Items.Remove(lstNamesDb.SelectedItems[0]);
                //lstNamesDb.Items.Remove(lstNamesDb.SelectedItems[0]);
            }
        }
    }
}
