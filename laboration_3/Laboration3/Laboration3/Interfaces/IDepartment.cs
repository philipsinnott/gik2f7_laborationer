using System.Collections.Generic;

namespace Laboration3
{
    public interface IDepartment
    {
        List<IEmployee> Employees { get; }
        int ID { get; }
        string Name { get; }
        string ToString();
    }
}