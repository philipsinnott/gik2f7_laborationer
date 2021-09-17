using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public static class PrintData
    {
        public static void TableEmployees(List<Employee> employees)
        {
            TableHeaderEmployee();
            foreach (Employee e in employees)
            {
                Console.Write($"  {e.FullName(),-22}");
                Console.Write($"  {e.Role.Title,-21}");
                Console.WriteLine($"{e.DateOfEmployment:yyyy-MM-dd}");
            }
        }
        public static void TableRoles(List<Role> roles)
        {
            TableHeaderRole();
            foreach (Role role in roles)
            {
                if (role.ID > 0)
                {
                    Console.Write($"  {role.ID,-7}");
                    Console.WriteLine($"{role.Title}");
                }
            }
        }
        public static void TableDepartments(List<Department> departments)
        {
            TableHeaderDepartment();
            foreach (Department dept in departments)
            {
                if (dept.ID > 0)
                {
                    Console.Write($"  {dept.ID,-7}");
                    Console.WriteLine($"{dept.Name}");
                }
            }
        }

        public static void TableDepartmentEmployees(List<Department> departments)
        {
            TableDepartments(departments);
            Console.Write("\nType which department ID you want to list: ");
            int.TryParse(Console.ReadLine(), out int numInput);
            List<Employee> employees = departments[numInput].Employees;
            TableEmployees(employees);
        }

        private static void TableHeaderDepartment()
        {
            Console.WriteLine($"-------------------------------------------------------------");
            Console.WriteLine($"| ID   | Department Name                                    |");
            Console.WriteLine($"-------------------------------------------------------------");
        }
        private static void TableHeaderRole()
        {
            Console.WriteLine($"-------------------------------------------------------------");
            Console.WriteLine($"| ID   | Role Title                                         |");
            Console.WriteLine($"-------------------------------------------------------------");
        }
        private static void TableHeaderEmployee()
        {
            Console.WriteLine($"------------------------------------------------------------------");
            Console.WriteLine($"| Full Name             | Role               | Date of Employment|");
            Console.WriteLine($"------------------------------------------------------------------");
        }
    }
}
