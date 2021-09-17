using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    class ConsoleUI
    {
        public static void MenuInteract(Company company, List<Employee> employees, List<Department> departments, List<Role> roles)
        {
            StandardMessages.DisplayStartupText();
            StandardMessages.DisplayHrLine();

            bool quitApp = false;
            while (!quitApp)
            {
                MenuMain();
                // ReadKey waits for input from the user, hides input with key 'true'
                ConsoleKeyInfo keypress = Console.ReadKey(true);

                switch (keypress.KeyChar)
                {
                    case '1':
                        Console.WriteLine("\n+==  COMPANY DETAILS  ======================================+\n");
                        company.GetDetails();
                        break;
                    case '2':
                        Console.WriteLine("\n+==  LIST OF ALL EMPLOYEES  ================================+\n");
                        PrintData.TableEmployees(employees);
                        break;
                    case '3':
                        Console.WriteLine("\n+==  LIST DEPARTMENTS & ROLES  =============================+\n");
                        PrintData.TableDepartments(departments);
                        PrintData.TableRoles(roles);
                        break;
                    case '4':
                        Console.WriteLine("\n+==  List of Employees in specified Department  ============+\n");
                        PrintData.TableDepartmentEmployees(departments);
                        break;
                    case 'r':
                    case 'R':
                        Console.Clear();
                        break;
                    case 'q':
                    case 'Q':
                        quitApp = true;
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
            }
            Console.Clear();
        }

        public static void MenuMain()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                "+=====================  ASSIGNMENT 3  ======================+\n" +
                "|  Press '1' Company Details                                |\n" +
                "|  Press '2' List All Employees                             |\n" +
                "|  Press '3' List Departments & Roles                       |\n" +
                "|  Press '4' List Employees in Department                   |\n" +
                "|-----------------------------------------------------------|\n" +
                "|  Press 'R' Reset the screen                               |\n" +
                "|  Press 'Q' to quit the program                            |\n" +
                "+===========================================================+"
                );
            Console.ResetColor();
        }
    }
}
