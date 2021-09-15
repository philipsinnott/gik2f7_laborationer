using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class Role
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Role()
        {

        }

        public Role(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }
}
