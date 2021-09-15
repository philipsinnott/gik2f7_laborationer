using System;
using System.Collections.Generic;

namespace Laboration3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Display startup text
            StandardMessages.DisplayStartupText();
            StandardMessages.DisplayHrLine();

            // Creates Employees
            List<Employee> employees = CreateData.CreateEmployees();

            // Print out Employees
            PrintData.PrintEmployees(employees);
            StandardMessages.DisplayHrLine();

            // Create Roles
            List<Role> roles = CreateData.CreateRoles();

            // Print out roles
            PrintData.PrintRoles(roles);
            StandardMessages.DisplayHrLine();

            // Create Departments
            List<Department> departments = CreateData.CreateDepartments();
            
            // Print out Departments
            PrintData.PrintDepartments(departments);
            StandardMessages.DisplayHrLine();

            // Create Company
            var company = new Company(
                "DICE (Digital Illusions CE AB)",
                "Södermalmsallén 36, 118 28 Stockholm Sweden",
                "556710-6520",
                "https://www.dice.se",
                departments
                );

            // Print Company Details
            company.GetDetails();
        }
        /*
            departments[0].Employees.Add(employees[0]);
            departments[0].Employees.Add(employees[1]);
            departments[1].Employees.Add(employees[2]);*/
    }
}
