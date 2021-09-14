using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public bool IsFired { get; set; } = false;

        public Employee()
        {

        }
        public Employee(string fName, string lName, DateTime dateOfEmployment)
        {
            FirstName = fName;
            LastName = lName;
            DateOfEmployment = dateOfEmployment;
        }


    }
}
