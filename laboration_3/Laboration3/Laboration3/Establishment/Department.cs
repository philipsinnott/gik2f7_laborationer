﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class Department : IGetDetails, IDepartment
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

        public void GetDetails()
        {
            Console.WriteLine($"ID:    {ID}");
            Console.WriteLine($"Name:  {Name}");
            Console.WriteLine($"{Environment.NewLine}Employees in Department:{Environment.NewLine}------------------------");
            foreach (IEmployee employee in Employees)
            {
                Console.WriteLine($"{employee.FullName()}");
            }
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name} Employees: {Employees}";
        }
    }
}