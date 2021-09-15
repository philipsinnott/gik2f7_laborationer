using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class Company : IGetDetails, INumberOfEmployees
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string OrganizationNumber { get; private set; }
        public string URL { get; private set; }

        public Company()
        {

        }

        public Company(string name, string address, string orgnr, string url)
        {
            Name = name;
            Address = address;
            OrganizationNumber = orgnr;
            URL = url;
        }

        public int GetNumberOfEmployees()
        {
            throw new NotImplementedException();
        }

        public void GetDetails()
        {
            Console.WriteLine($"Company name:     {Name}");
            Console.WriteLine($"Address:          {Address}");
            Console.WriteLine($"Organization nr.: {OrganizationNumber}");
            Console.WriteLine($"Website URL:      {URL}");
        }
    }
}
