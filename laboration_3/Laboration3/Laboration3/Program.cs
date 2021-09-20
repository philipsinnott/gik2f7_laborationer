using System;
using System.Collections.Generic;

namespace Laboration3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create lists populated with simulated data
            List<Role> roles = CreateData.AddRoles();
            List<Employee> employees = CreateData.AddEmployees(roles);
            List<Department> departments = CreateData.AddDepartments();
            CreateData.AssignToDepartment(departments, employees);

            // Instatiate the Company with Information
            var company = new Company(
                "DICE",
                "Södermalmsallén 36, 118 28 Stockholm Sweden",
                "556710-6520",
                "https://www.dice.se",
                departments);

            //foreach (var item in roles)
            //{
            //    StandardMessages.DisplayHrLine();
            //    item.GetDetails();
            //}
            //foreach (var item in departments)
            //{
            //    StandardMessages.DisplayHrLine();
            //    item.GetDetails();
            //}
            //foreach (var item in employees)
            //{
            //    StandardMessages.DisplayHrLine();
            //    item.GetDetails();
            //}

            // Display Console Menu
            ConsoleUI.MenuInteract(company, employees, departments, roles);
            
        }
    }
}
