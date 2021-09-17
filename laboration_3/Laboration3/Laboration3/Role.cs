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
        public string Title { get; private set; }

        public Role(int id, string name)
        {
            ID = id;
            Title = name;
        }
    }
}
