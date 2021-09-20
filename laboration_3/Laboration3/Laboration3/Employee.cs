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
        public Role Role { get; private set; }

        public Employee()
        {

        }
        public Employee(string fName, string lName, DateTime dateOfEmployment, Role role)
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

        public void GetDetails()
        {
            Console.WriteLine($"Full name:          {FullName()}");
            Console.WriteLine($"Date of Employment: {DateOfEmployment}");
            Console.WriteLine($"Is Fired:           {IsFired}");
            Console.WriteLine($"Role:               {Role.Title}");
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}, DateOfEmployment: {DateOfEmployment}, IsFired: {IsFired}, Role: {Role}";
        }
    }
}
