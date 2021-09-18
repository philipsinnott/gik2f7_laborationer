using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class DataCapture
    {
        public static List<Employee> CreateNewStaffMember(List<Employee> employees, List<Role> role)
        {
            Console.WriteLine("First name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last name:");
            string lastName = Console.ReadLine();

            Random rnd = new();
            int roles = rnd.Next(1, 16);
            employees.Add(new Employee(firstName, lastName, DateTime.Now, CreateData.SelectID(role, roles)));
            Console.WriteLine($"Staff member {firstName} {lastName} has been added.");
            return employees;
        }
        public static void AddStaffMemberToDepartment(List<Employee> employees, List<Department> department)
        {
            Random rnd = new();
            int departments = rnd.Next(1, 6);
            department[departments].Employees.Add(employees[22]);
        }
    }
}
