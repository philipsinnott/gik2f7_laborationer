using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class Company : INumberOfEmployees
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string OrganizationNumber { get; private set; }
        public string URL { get; private set; }

        public int GetNumberOfEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
