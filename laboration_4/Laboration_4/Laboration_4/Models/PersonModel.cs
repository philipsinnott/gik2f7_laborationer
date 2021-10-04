using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4.Models
{
    public class PersonModel
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
        public PersonModel()
        {

        }
        public PersonModel(string username, string firstName, string lastName, string email)
        {
            username = Username;
            firstName = FirstName;
            lastName = LastName;
            email = Email;
        }
    }
}
