using System;
using System.Collections.Generic;

namespace Laboration3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create lists populated with simulated data
            List<IRole> roles = CreateData.AddRoles();
            List<IEmployee> employees = CreateData.AddEmployees(roles);
            List<IDepartment> departments = CreateData.AddDepartments();
            CreateData.AssignToDepartment(departments, employees);

            // Instatiate the Company with Information
            var company = new Company(
                "DICE",
                "Södermalmsallén 36, 118 28 Stockholm Sweden",
                "556710-6520",
                "https://www.dice.se",
                departments);

            // Display Console Menu
            ConsoleUI.MenuInteract(company, employees, departments, roles);
            
        }
    }
}
