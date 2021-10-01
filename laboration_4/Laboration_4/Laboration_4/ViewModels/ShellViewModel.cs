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

namespace Laboration_4.ViewModels
{
    public class ShellViewModel : Screen
    {
        //private string _firstName = "Philip";
        //private string _lastName;
        //private string _email;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        private PersonModel _selectedPerson;

        public ShellViewModel()
        {
            List<PersonModel> ClassMates = new List<PersonModel>();
            CsvManager.ReadCsv(ClassMates);
            //People.Add(new PersonModel { FirstName = "Person 1", LastName = "Corey" });
            //People.Add(new PersonModel { FirstName = "Person 2", LastName = "Jefferson" });
            //People.Add(new PersonModel { FirstName = "Person 3", LastName = "Swagson" });
        }

        public BindableCollection<PersonModel> People
        {
            get
            {
                return _people;
            }
            set
            {
                _people = value;
            }
        }
        public PersonModel SelectedPerson
        {
            get
            {
                return _selectedPerson;
            }
            set
            {
                _selectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }

        //public string FirstName
        //{
        //    get
        //    {
        //        return _firstName;
        //    }
        //    set
        //    {
        //        _firstName = value;
        //        NotifyOfPropertyChange(() => FirstName);
        //        NotifyOfPropertyChange(() => FullName);
        //    }
        //}
        //public string LastName
        //{
        //    get
        //    {
        //        return _lastName;
        //    }
        //    set
        //    {
        //        _lastName = value;
        //        NotifyOfPropertyChange(() => LastName);
        //        NotifyOfPropertyChange(() => FullName);
        //    }
        //}
        //public string Email
        //{
        //    get
        //    {
        //        return _email;
        //    }
        //    set
        //    {
        //        _email = value;
        //        NotifyOfPropertyChange(() => Email);
        //    }
        //}
        //public string FullName
        //{
        //    get { return $"{FirstName} {LastName}"; }
        //}

        //public BindableCollection<PersonModel> People
        //{
        //    get
        //    {
        //        return _people; 
        //    }
        //    set
        //    {
        //        _people = value; 
        //    }
        //}
        //public PersonModel SelectedPerson
        //{
        //    get
        //    {
        //        return _selectedPerson; 
        //    }
        //    set
        //    {
        //        _selectedPerson = value;
        //        NotifyOfPropertyChange(() => SelectedPerson);
        //    }
        //}
        //public bool CanClearText(string firstName, string lastName, string email)
        //{
        //    if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName) && string.IsNullOrWhiteSpace(email))
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
        //public void ClearText(string firstName, string lastName, string email)
        //{
        //    FirstName = "";
        //    LastName = "";
        //    Email = "";
        //}
    }
}
