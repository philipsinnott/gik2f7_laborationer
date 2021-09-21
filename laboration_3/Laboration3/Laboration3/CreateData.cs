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
        public static List<Role> AddRoles()
        {
            List<Role> output = new();
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
        public static List<Employee> AddEmployees(List<Role> roles)
        {
            List<Employee> output = new List<Employee>();
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
        public static List<Department> AddDepartments()
        {
            List<Employee> unassigned = new();
            List<Employee> management = new();
            List<Employee> producers = new();
            List<Employee> hr = new();
            List<Employee> designers = new();
            List<Employee> developers = new();

            List<Department> output = new();
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
        public static void AssignToDepartment(List<Department> deptartment, List<Employee> employee)
        {
            deptartment[5].Employees.Add(employee[0]);
            deptartment[5].Employees.Add(employee[1]);
            deptartment[2].Employees.Add(employee[2]);
            deptartment[2].Employees.Add(employee[3]);
            deptartment[4].Employees.Add(employee[4]);
            deptartment[5].Employees.Add(employee[5]);
            deptartment[5].Employees.Add(employee[6]);
            deptartment[4].Employees.Add(employee[7]);
            deptartment[4].Employees.Add(employee[8]);
            deptartment[4].Employees.Add(employee[9]);
            deptartment[4].Employees.Add(employee[10]);
            deptartment[4].Employees.Add(employee[11]);
            deptartment[4].Employees.Add(employee[12]);
            deptartment[4].Employees.Add(employee[13]);
            deptartment[1].Employees.Add(employee[14]);
            deptartment[1].Employees.Add(employee[15]);
            deptartment[1].Employees.Add(employee[16]);
            deptartment[1].Employees.Add(employee[17]);
            deptartment[3].Employees.Add(employee[18]);
            deptartment[3].Employees.Add(employee[19]);
            deptartment[1].Employees.Add(employee[20]);
            deptartment[2].Employees.Add(employee[21]);
        }

        /// <summary>
        /// Add Employee to List of Employees 
        /// </summary>
        /// <param name="employees"></param>
        /// <param name="employee"></param>
        public static void AddEmployee(List<Employee> employees, Employee employee)
        {
            employees.Add(employee);
        }

        /// <summary>
        /// Assigns last employee in List of Employees to specified Department
        /// </summary>
        /// <param name="employees"></param>
        /// <param name="departments"></param>
        /// <param name="id"></param>
        public static void AssignEmployeeToDepartment(List<Employee> employees, List<Department> departments, int id)
        {
            departments[id].Employees.Add(employees[employees.Count - 1]);
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
