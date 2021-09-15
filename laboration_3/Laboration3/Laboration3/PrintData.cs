using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public static class PrintData
    {
        public static void PrintEmployees(List<Employee> employees)
        {
            foreach (Employee e in employees)
            {
                Console.WriteLine($"{e.FullName()} is employed as a {e.Role.Name} at DICE and was hired {e.DateOfEmployment:Y}.");
            }
        }
        public static void PrintRoles(List<Role> roles)
        {
            foreach (Role role in roles)
            {
                Console.WriteLine($"ID: {role.ID}, Name: {role.Name}     Description: {role.Description}.");
            }
        }
        public static void PrintDepartments(List<Department> departments)
        {
            foreach (Department dept in departments)
            {
                Console.WriteLine($"ID: {dept.ID}, Name: {dept.Name}\nDescription: {dept.Description}.");
                foreach (var employee in dept.Employees)
                {
                    Console.WriteLine($"Fullname: {employee.FullName()}");
                }
            }
        }
    }
}
