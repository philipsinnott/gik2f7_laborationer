using System;
using System.Collections.Generic;

namespace Laboration3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instatiate classes and create lists populated with dummy data
            //DataCreator dc = new();
            List<Role> roles = CreateData.CreateRoles();
            List<Employee> employees = CreateData.CreateEmployees(roles);
            List<Department> departments = CreateData.CreateDepartments();
            CreateData.AssignToDepartment(departments, employees);
            var company = new Company(
                "DICE",
                "Södermalmsallén 36, 118 28 Stockholm Sweden",
                "556710-6520",
                "https://www.dice.se",
                departments);

            /*DataCapture.CreateNewStaffMember(roles);*/
            // Display Console Menu
            ConsoleUI.MenuInteract(company, employees, departments, roles);
            
        }
    }
}
