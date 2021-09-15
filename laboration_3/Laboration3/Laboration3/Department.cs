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

        public Department()
        {

        }

        public Department(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }

        public int GetNumberOfEmployees()
        {
            throw new NotImplementedException();
        }

        //public List<Department> CreateDepartment(int id, string name, string description)
        //{
        //    return new Department() { ID = id, Name = name, Description = description };
        //}
    }
}
