using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class CreateData
    {
        public static List<Employee> CreateEmployees()
        {
            List<Employee> output = new List<Employee>();
            output.Add(new Employee("Anders", "Hallberg", Convert.ToDateTime("2014-08-05")));
            output.Add(new Employee("Anders", "Lind", Convert.ToDateTime("2013-12-22")));
            output.Add(new Employee("Amo", "Mostofi", Convert.ToDateTime("2012-12-05")));
            output.Add(new Employee("Elin", "Holmberg", Convert.ToDateTime("2018-02-05")));
            output.Add(new Employee("Edvin", "Eriksson", Convert.ToDateTime("2020-07-16")));
            return output;
        }

        public static List<Department> CreateDepartments()
        {
            List<Employee> dept10 = new();
            List<Employee> dept20 = new();
            List<Employee> dept30 = new();
            List<Employee> dept40 = new();
            List<Employee> dept50 = new();

            List<Department> output = new();
            output.Add(new Department(10, "Developers", "Description of developer department", dept10));
            output.Add(new Department(20, "HR", "Description of HR department", dept20));
            output.Add(new Department(30, "QA", "Description of QA department", dept30));
            output.Add(new Department(40, "Designers", "Description of Designer department", dept40));
            output.Add(new Department(50, "Producers", "Description of Producer department", dept50));
            return output;
        }

        public static List<Role> CreateRoles()
        {
            List<Role> output = new();
            output.Add(new Role(1, "Developer Director", "Part of Management"));
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
