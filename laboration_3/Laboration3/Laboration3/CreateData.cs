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
        public static List<Employee> AddEmployees(List<Role> role)
        {
            List<Employee> output = new List<Employee>();
            output.Add(new Employee("Anders", "Hallberg", ToDate("2014-08-05"), SelectID(role, 13)));
            output.Add(new Employee("Anders", "Lind", ToDate("2013-12-22"), SelectID(role, 13)));
            output.Add(new Employee("Amo", "Mostofi", ToDate("2012-12-05"), SelectID(role, 5)));
            output.Add(new Employee("Elin", "Holmberg", ToDate("2018-02-14"), SelectID(role, 5)));
            output.Add(new Employee("Edvin", "Eriksson", ToDate("2020-07-18"), SelectID(role, 11)));
            output.Add(new Employee("Per", "Bergqvist", ToDate("2002-05-14"), SelectID(role, 14)));
            output.Add(new Employee("Jonatan", "McEvenue", ToDate("2016-07-17"), SelectID(role, 15)));
            output.Add(new Employee("Julien", "Petotte", ToDate("2015-07-11"), SelectID(role, 11)));
            output.Add(new Employee("Pawel", "Nowak", ToDate("2020-01-16"), SelectID(role, 11)));
            output.Add(new Employee("Niels", "Vaes", ToDate("2017-07-19"), SelectID(role, 9)));
            output.Add(new Employee("Mattias", "Kirsten", ToDate("2020-07-27"), SelectID(role, 9)));
            output.Add(new Employee("Tommy", "Rydling", ToDate("2016-11-24"), SelectID(role, 10)));
            output.Add(new Employee("Theodor", "Gerhamn", ToDate("2019-12-12"), SelectID(role, 10)));
            output.Add(new Employee("Philip", "Eriksson", ToDate("2018-07-16"), SelectID(role, 12)));
            output.Add(new Employee("Timmy", "Jonsson", ToDate("2020-07-11"), SelectID(role, 1)));
            output.Add(new Employee("Paul", "Watson", ToDate("2020-07-16"), SelectID(role, 2)));
            output.Add(new Employee("Oskar", "Steinhauf", ToDate("2016-09-22"), SelectID(role, 3)));
            output.Add(new Employee("Stuart", "Watson", ToDate("2010-06-16"), SelectID(role, 3)));
            output.Add(new Employee("Niklas", "Domander", ToDate("2012-07-30"), SelectID(role, 7)));
            output.Add(new Employee("Marina", "Waltari", ToDate("2012-07-16"), SelectID(role, 8)));
            output.Add(new Employee("Karin", "Thulin Carlberg", ToDate("2020-07-23"), SelectID(role, 4)));
            output.Add(new Employee("John", "Wasilczyk", ToDate("2014-01-11"), SelectID(role, 6)));
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
        public static void AssignToDepartment(List<Department> dept, List<Employee> emp)
        {
            dept[5].Employees.Add(emp[0]);
            dept[5].Employees.Add(emp[1]);
            dept[2].Employees.Add(emp[2]);
            dept[2].Employees.Add(emp[3]);
            dept[4].Employees.Add(emp[4]);
            dept[5].Employees.Add(emp[5]);
            dept[5].Employees.Add(emp[6]);
            dept[4].Employees.Add(emp[7]);
            dept[4].Employees.Add(emp[8]);
            dept[4].Employees.Add(emp[9]);
            dept[4].Employees.Add(emp[10]);
            dept[4].Employees.Add(emp[11]);
            dept[4].Employees.Add(emp[12]);
            dept[4].Employees.Add(emp[13]);
            dept[1].Employees.Add(emp[14]);
            dept[1].Employees.Add(emp[15]);
            dept[1].Employees.Add(emp[16]);
            dept[1].Employees.Add(emp[17]);
            dept[3].Employees.Add(emp[18]);
            dept[3].Employees.Add(emp[19]);
            dept[1].Employees.Add(emp[20]);
            dept[2].Employees.Add(emp[21]);
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
        /// Search List with Role ID. If ID not found return a default value
        /// </summary>
        /// <param name="item"></param>
        /// <param name="id"></param>
        /// <returns>Role object</returns>
        public static Role SelectID(List<Role> item, int id)
        {
            return item.SingleOrDefault(x => x.ID == id) ?? item[0];
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
