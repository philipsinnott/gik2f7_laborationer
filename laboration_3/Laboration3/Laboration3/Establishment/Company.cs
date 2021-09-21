using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class Company : IGetDetails, INumberOfEmployees, ICompany
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string OrganizationNumber { get; private set; }
        public string URL { get; private set; }
        public List<IDepartment> Departments { get; set; }

        public Company(string name, string address, string orgnr, string url, List<IDepartment> departments)
        {
            Name = name;
            Address = address;
            OrganizationNumber = orgnr;
            URL = url;
            Departments = departments;
        }

        public int GetNumberOfEmployees()
        {
            int numOfEmployees = 0;
            List<IEmployee> employees;

            foreach (IDepartment dept in Departments)
            {
                employees = dept.Employees;
                foreach (var employee in employees)
                {
                    numOfEmployees++;
                }
            }
            return numOfEmployees;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Company name:     {Name}");
            Console.WriteLine($"Address:          {Address}");
            Console.WriteLine($"Organization nr.: {OrganizationNumber}");
            Console.WriteLine($"Website URL:      {URL}");
            Console.WriteLine($"No. of Employees: {GetNumberOfEmployees()}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}, OrganizationNumber: {OrganizationNumber}, URL: {URL}, Department List: {Departments}";
        }
    }
}
