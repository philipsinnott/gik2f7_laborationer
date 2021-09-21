using System;

namespace Laboration3
{
    public interface IEmployee
    {
        DateTime DateOfEmployment { get; }
        string FirstName { get; }
        bool IsFired { get; }
        string LastName { get; }
        IRole Role { get; }
        string FullName();
    }
}