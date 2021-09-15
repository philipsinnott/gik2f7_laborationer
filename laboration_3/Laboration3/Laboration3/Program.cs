using System;
using System.Collections.Generic;

namespace Laboration3
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            // Create Company
            var company = new Company(
                "DICE (Digital Illusions CE AB)",
                "Södermalmsallén 36, 118 28 Stockholm Sweden",
                "556710-6520",
                "https://www.dice.se");

            // Print Company Details
            company.GetDetails();

            Console.WriteLine();

            // Creates Employees
            List<Employee> employees = CreateEmployees();

            // Print out Employees
            foreach (Employee e in employees)
            {
               Console.WriteLine($"Hi, I'm {e.FullName()}, I was employed at DICE in {e.DateOfEmployment:Y}.");
            }

            Console.WriteLine();

            List<Role> roles = CreateRoles();

            // Print out Departments
            foreach (Role role in roles)
            {
                Console.WriteLine($"ID: {role.ID}, Name: {role.Name}     Description: {role.Description}.");
            }

            Console.WriteLine();

            // Create Departments
            List<Department> departments = CreateDepartments();

            // Print out Departments
            foreach (Department dept in departments)
            {
                Console.WriteLine($"ID: {dept.ID}, Name: {dept.Name}\nDescription: {dept.Description}.");
            }


        }

        public static List<Employee> CreateEmployees()
        {
            List<Employee> output = new List<Employee>();
            output.Add(new Employee ("Anders", "Hallberg", Convert.ToDateTime("2014-08-05")));
            output.Add(new Employee ("Anders", "Lind",Convert.ToDateTime("2013-12-22")));
            output.Add(new Employee ("Amo", "Mostofi", Convert.ToDateTime("2012-12-05")));
            output.Add(new Employee ("Elin", "Holmberg", Convert.ToDateTime("2018-02-05")));
            output.Add(new Employee ("Edvin", "Eriksson", Convert.ToDateTime("2020-07-16")));
            return output;
        }

        public static List<Department> CreateDepartments()
        {
            List<Department> output = new();
            output.Add(new Department(10, "Developers", "Description of developer department"));
            output.Add(new Department(20, "HR", "Description of HR department"));
            output.Add(new Department(30, "QA", "Description of QA department"));
            output.Add(new Department(40, "Designers", "Description of Designer department"));
            output.Add(new Department(50, "Producers", "Description of Producer department"));
            return output;
        }

        public static List<Role> CreateRoles()
        {
            List<Role> output = new();
            output.Add(new Role(1, "Developer Director","Part of Management"));
            output.Add(new Role(2, "QA Project Manager", "Part of Management"));
            output.Add(new Role(3, "Quality Analyst", "Part of Management"));
            output.Add(new Role(4, "Senior IT Manager", "Part of Management"));
            output.Add(new Role(5, "Producer", "Part of Producers"));
            output.Add(new Role(6, "Executive Producer", "Part of Producers"));
            output.Add(new Role(7, "Senior HR Manager", "Part of HR"));
            output.Add(new Role(8, "HR Coordinator", "Part of HR"));
            output.Add(new Role(9, "Animator", "Part of Designers"));
            output.Add(new Role(10, "Game Designer", "Part of Designers"));
            output.Add(new Role(11, "Level Designer", "Part of Designers"));
            output.Add(new Role(12, "Sound Designer", "Part of Designers"));
            output.Add(new Role(13, "Software Engineer", "Part of Developers"));
            output.Add(new Role(14, "UI Software Engineer", "Part of Developers"));
            output.Add(new Role(15, "System Engineer", "Part of Developers"));
            return output;
        }
    }
}
