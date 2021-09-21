using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class CreateData
    {
        /// <summary>
        /// Create a List filled with predefined Role objects
        /// </summary>
        /// <returns>List of Role objects</returns>
        public static List<IRole> AddRoles()
        {
            List<IRole> output = new();
            output.Add(new Role(0, "Unassigned"));
            output.Add(new Role(1, "Developer Director"));  // Management
            output.Add(new Role(2, "QA Project Manager"));  // Management
            output.Add(new Role(3, "Quality Analyst"));     // Management
            output.Add(new Role(4, "Senior IT Manager"));   // Management
            output.Add(new Role(5, "Producer"));            // Producers
            output.Add(new Role(6, "Executive Producer"));  // Producers
            output.Add(new Role(7, "Senior HR Manager"));   // HR
            output.Add(new Role(8, "HR Coordinator"));      // HR
            output.Add(new Role(9, "Animator"));            // Designers
            output.Add(new Role(10, "Game Designer"));      // Designers
            output.Add(new Role(11, "Level Designer"));     // Designers
            output.Add(new Role(12, "Sound Designer"));     // Designers
            output.Add(new Role(13, "Software Engineer"));  // Developer
            output.Add(new Role(14, "UI Software Engineer"));// Developer
            output.Add(new Role(15, "System Engineer"));    // Developer
            return output;
        }

        /// <summary>
        /// Create a List filled with predefined Employee objects
        /// </summary>
        /// <returns>List of Employee objects</returns>
        public static List<IEmployee> AddEmployees(List<IRole> roles)
        {
            List<IEmployee> output = new List<IEmployee>();
            output.Add(new Employee("Anders", "Hallberg", ToDate("2014-08-05"), roles[13]));
            output.Add(new Employee("Anders", "Lind", ToDate("2013-12-22"), roles[13]));
            output.Add(new Employee("Amo", "Mostofi", ToDate("2012-12-05"), roles[5]));
            output.Add(new Employee("Elin", "Holmberg", ToDate("2018-02-14"), roles[5]));
            output.Add(new Employee("Edvin", "Eriksson", ToDate("2020-07-18"), roles[11]));
            output.Add(new Employee("Per", "Bergqvist", ToDate("2002-05-14"), roles[14]));
            output.Add(new Employee("Jonatan", "McEvenue", ToDate("2016-07-17"), roles[15]));
            output.Add(new Employee("Julien", "Petotte", ToDate("2015-07-11"), roles[11]));
            output.Add(new Employee("Pawel", "Nowak", ToDate("2020-01-16"), roles[11]));
            output.Add(new Employee("Niels", "Vaes", ToDate("2017-07-19"), roles[9]));
            output.Add(new Employee("Mattias", "Kirsten", ToDate("2020-07-27"), roles[9]));
            output.Add(new Employee("Tommy", "Rydling", ToDate("2016-11-24"), roles[10]));
            output.Add(new Employee("Theodor", "Gerhamn", ToDate("2019-12-12"), roles[10]));
            output.Add(new Employee("Philip", "Eriksson", ToDate("2018-07-16"), roles[12]));
            output.Add(new Employee("Timmy", "Jonsson", ToDate("2020-07-11"), roles[1]));
            output.Add(new Employee("Paul", "Watson", ToDate("2020-07-16"), roles[2]));
            output.Add(new Employee("Oskar", "Steinhauf", ToDate("2016-09-22"), roles[3]));
            output.Add(new Employee("Stuart", "Watson", ToDate("2010-06-16"), roles[3]));
            output.Add(new Employee("Niklas", "Domander", ToDate("2012-07-30"), roles[7]));
            output.Add(new Employee("Marina", "Waltari", ToDate("2012-07-16"), roles[8]));
            output.Add(new Employee("Karin", "Thulin Carlberg", ToDate("2020-07-23"), roles[4]));
            output.Add(new Employee("John", "Wasilczyk", ToDate("2014-01-11"), roles[6]));
            return output;
        }

        /// <summary>
        /// Create a List filled with predefined Department objects
        /// </summary>
        /// <returns>List of Department objects</returns>
        public static List<IDepartment> AddDepartments()
        {
            List<IEmployee> unassigned = new();
            List<IEmployee> management = new();
            List<IEmployee> producers = new();
            List<IEmployee> hr = new();
            List<IEmployee> designers = new();
            List<IEmployee> developers = new();

            List<IDepartment> output = new();
            output.Add(new Department(0, "Unassigned", unassigned));
            output.Add(new Department(1, "Management", management));
            output.Add(new Department(2, "Producers", producers));
            output.Add(new Department(3, "HR", hr));
            output.Add(new Department(4, "Designers", designers));
            output.Add(new Department(5, "Developers", developers));
            return output;
        }

        /// <summary>
        /// Assign employees to specific departments
        /// </summary>
        /// <returns></returns>
        public static void AssignToDepartment(List<IDepartment> departments, List<IEmployee> employees)
        {
            departments[5].Employees.Add(employees[0]);
            departments[5].Employees.Add(employees[1]);
            departments[2].Employees.Add(employees[2]);
            departments[2].Employees.Add(employees[3]);
            departments[4].Employees.Add(employees[4]);
            departments[5].Employees.Add(employees[5]);
            departments[5].Employees.Add(employees[6]);
            departments[4].Employees.Add(employees[7]);
            departments[4].Employees.Add(employees[8]);
            departments[4].Employees.Add(employees[9]);
            departments[4].Employees.Add(employees[10]);
            departments[4].Employees.Add(employees[11]);
            departments[4].Employees.Add(employees[12]);
            departments[4].Employees.Add(employees[13]);
            departments[1].Employees.Add(employees[14]);
            departments[1].Employees.Add(employees[15]);
            departments[1].Employees.Add(employees[16]);
            departments[1].Employees.Add(employees[17]);
            departments[3].Employees.Add(employees[18]);
            departments[3].Employees.Add(employees[19]);
            departments[1].Employees.Add(employees[20]);
            departments[2].Employees.Add(employees[21]);
        }

        /// <summary>
        /// Add Employee to List of Employees 
        /// </summary>
        /// <param name="employees"></param>
        /// <param name="employee"></param>
        public static void AddEmployee(List<IEmployee> employees, IEmployee employee)
        {
            employees.Add(employee);
            Console.WriteLine();
            Console.WriteLine($"Added {employee.FullName()}.");
        }

        /// <summary>
        /// Assigns last employee in List of Employees to specified Department
        /// </summary>
        /// <param name="employees"></param>
        /// <param name="departments"></param>
        /// <param name="id"></param>
        public static void AssignEmployeeToDepartment(List<IEmployee> employees, List<IDepartment> departments, int id)
        {
            departments[id].Employees.Add(employees[employees.Count - 1]);
            Console.WriteLine();
            Console.WriteLine($"Assigned to {departments[id].Name}.");
        }

        /// <summary>
        /// Shorter version for Converting to DateTime
        /// </summary>
        /// <param name="str"></param>
        /// <returns>DateTime value</returns>
        public static DateTime ToDate(string str)
        {
            return Convert.ToDateTime(str);
        }
    }
}
