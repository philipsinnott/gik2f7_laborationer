using System;
using System.Collections.Generic;

namespace Laboration3
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            /*Employee e = new("Mattias", "Hedlund", Convert.ToDateTime("2012-12-05"));*/
            List<Employee> ListOfEmployees = CreateStaticEmployees();
            foreach (Employee e in ListOfEmployees)
            {
               Console.WriteLine($"Hello employee {e.FirstName}");
            }
            /*Console.WriteLine($"Hello employee {e.LastName}");*/
        }

        public static List<Employee> CreateStaticEmployees()
        {
            List<Employee> output = new List<Employee>();
            output.Add(new Employee { FirstName = "Anders", LastName = "Hallberg", DateOfEmployment = Convert.ToDateTime("2014-08-05") });
            output.Add(new Employee { FirstName = "Anders", LastName = "Lind", DateOfEmployment = Convert.ToDateTime("2013-12-22") });
            output.Add(new Employee { FirstName = "Amo", LastName = "Mostofi", DateOfEmployment = Convert.ToDateTime("2012-12-05") });
            output.Add(new Employee { FirstName = "Elin", LastName = "Holmberg", DateOfEmployment = Convert.ToDateTime("2018-02-05") });
            output.Add(new Employee { FirstName = "Edvin", LastName = "Eriksson", DateOfEmployment = Convert.ToDateTime("2020-07-16") });
            return output;
        }
    }
}
