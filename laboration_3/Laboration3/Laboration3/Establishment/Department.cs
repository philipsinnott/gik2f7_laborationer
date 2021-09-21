using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class Department : IDepartment
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public List<IEmployee> Employees { get; private set; }

        public Department(int id, string name, List<IEmployee> employees)
        {
            ID = id;
            Name = name;
            Employees = employees;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name} Employees: {Employees}";
        }
    }
}
