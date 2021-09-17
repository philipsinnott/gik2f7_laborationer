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
        public List<Employee> Employees { get; private set; }

        public Department(int id, string name, List<Employee> employees)
        {
            ID = id;
            Name = name;
            Employees = employees;
        }

        public int GetNumberOfEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
