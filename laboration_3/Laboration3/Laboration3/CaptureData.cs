using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class CaptureData
    {
        /// <summary>
        /// Take input from user to construct Employee object
        /// </summary>
        /// <param name="roles"></param>
        /// <returns>Employee object</returns>
        public static Employee CaptureEmployee(List<Role> roles)
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();

            DateTime dateOfEmployment;
            do {
                Console.Write("Date of Employment [YYYY-MM-DD]: ");
                DateTime.TryParse(Console.ReadLine(), out dateOfEmployment);
            } while (dateOfEmployment > DateTime.Today.AddYears(1) || dateOfEmployment < DateTime.Today.AddYears(-80));

            DisplayTable.TableRoles(roles);

            int roleId;
            do {
                Console.Write($"Select Role ID [1-{roles.Count - 1}]: ");
                int.TryParse(Console.ReadLine(), out roleId);
            } while (roleId >= roles.Count || roleId < 1);

            Employee employee = new(firstName, lastName, dateOfEmployment, roles[roleId]);
            return employee;
        }

        /// <summary>
        /// Take input from user regarding Department ID
        /// </summary>
        /// <returns>Integer value</returns>
        public static int CaptureDepartmentId(List<Department> departments)
        {
            int departmentId;
            do {
                Console.Write($"Select Department ID [1-{departments.Count - 1}]: ");
                int.TryParse(Console.ReadLine(), out departmentId);
            } while (departmentId >= departments.Count || departmentId < 1);
            return departmentId;
        }
    }
}
