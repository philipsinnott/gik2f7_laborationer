using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4_NoFW.Models
{
    public class PersonModel
    {
        public string Username { get; set; } = "default_username";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public PersonModel()
        {

        }
    }
}
