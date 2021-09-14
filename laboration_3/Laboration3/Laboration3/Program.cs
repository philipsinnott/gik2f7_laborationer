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
    }
}
