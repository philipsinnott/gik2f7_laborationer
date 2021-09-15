using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class Department : INumberOfEmployees
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<Employee> Employees { get; private set; }

        public Department(int id, string name, string description, List<Employee> employees)
        {
            ID = id;
            Name = name;
            Description = description;
            Employees = employees;
        }

        public int GetNumberOfEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
