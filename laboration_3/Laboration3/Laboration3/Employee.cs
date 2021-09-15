using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfEmployment { get; private set; }
        public bool IsFired { get; private set; } = false;

        public Employee()
        {

        }
        public Employee(string fName, string lName, DateTime dateOfEmployment)
        {
            FirstName = fName;
            LastName = lName;
            DateOfEmployment = dateOfEmployment;
        }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
