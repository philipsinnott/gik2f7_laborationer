using System.Collections.Generic;

namespace Laboration3
{
    public interface ICompany
    {
        string Address { get; }
        List<IDepartment> Departments { get; set; }
        string Name { get; }
        string OrganizationNumber { get; }
        string URL { get; }

        void GetDetails();
        int GetNumberOfEmployees();
        string ToString();
    }
}