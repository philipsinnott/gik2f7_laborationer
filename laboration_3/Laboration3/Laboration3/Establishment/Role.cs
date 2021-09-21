using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class Role : IGetDetails, IRole
    {
        public int ID { get; private set; }
        public string Title { get; private set; }

        public Role(int id, string title)
        {
            ID = id;
            Title = title;
        }

        public void GetDetails()
        {
            Console.WriteLine($"ID:    {ID}");
            Console.WriteLine($"Title: {Title}");
        }

        public override string ToString()
        {
            return $"ID: {ID}, Title: {Title}";
        }
    }
}
