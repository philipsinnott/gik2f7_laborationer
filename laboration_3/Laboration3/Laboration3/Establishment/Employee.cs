using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class Employee : IEmployee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfEmployment { get; private set; }
        public bool IsFired { get; private set; } = false;
        public IRole Role { get; private set; }

        public Employee(string fName, string lName, DateTime dateOfEmployment, IRole role)
        {
            FirstName = fName;
            LastName = lName;
            DateOfEmployment = dateOfEmployment;
            Role = role;
        }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}, DateOfEmployment: {DateOfEmployment}, IsFired: {IsFired}, Role: {Role}";
        }
    }
}
