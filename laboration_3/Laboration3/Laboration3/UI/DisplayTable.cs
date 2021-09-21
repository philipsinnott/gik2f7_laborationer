using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public static class DisplayTable
    {
        public static void TableEmployees(List<IEmployee> employees)
        {
            TableHeaderEmployee();
            foreach (IEmployee e in employees)
            {
                Console.Write($"  {e.FullName(),-22}");
                Console.Write($"  {e.Role.Title,-21}");
                Console.WriteLine($"{e.DateOfEmployment:yyyy-MM-dd}");
            }
        }
        public static void TableRoles(List<IRole> roles)
        {
            TableHeaderRole();
            foreach (IRole role in roles)
            {
                if (role.ID > 0)
                {
                    Console.Write($"  {role.ID,-7}");
                    Console.WriteLine($"{role.Title}");
                }
            }
        }
        public static void TableDepartments(List<IDepartment> departments)
        {
            TableHeaderDepartment();
            foreach (IDepartment dept in departments)
            {
                if (dept.ID > 0)
                {
                    Console.Write($"  {dept.ID,-7}");
                    Console.WriteLine($"{dept.Name}");
                }
            }
        }

        public static void TableDepartmentEmployees(List<IDepartment> departments)
        {
            TableDepartments(departments);
            int userInput = CaptureData.CaptureDepartmentId(departments);
            if (userInput < departments.Count && userInput > 0)
            {
                List<IEmployee> employees = departments[userInput].Employees;
                TableEmployees(employees);
            }
            else
            {
                Console.WriteLine($"Invalid input, Enter a number between 1 - {departments.Count - 1}");
            }


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
