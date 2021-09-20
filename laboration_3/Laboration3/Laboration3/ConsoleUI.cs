using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class ConsoleUI
    {
        public static void MenuInteract(Company company, List<Employee> employees, List<Department> departments, List<Role> roles)
        {
            StandardMessages.DisplayStartupText();
            StandardMessages.DisplayHrLine();

            bool quitApp = false;
            while (!quitApp)
            {
                DisplayMenu();
                // ReadKey waits for input from the user, hides input with key 'true'
                ConsoleKeyInfo keypress = Console.ReadKey(true);

                switch (keypress.KeyChar)
                {
                    case '1':
                        Console.WriteLine($"{Environment.NewLine}+==  COMPANY DETAILS  ======================================+{Environment.NewLine}");
                        company.GetDetails();
                        break;
                    case '2':
                        Console.WriteLine($"{Environment.NewLine}+==  LIST OF ALL EMPLOYEES  ================================+{Environment.NewLine}");
                        DisplayTable.TableEmployees(employees);
                        break;
                    case '3':
                        Console.WriteLine($"{Environment.NewLine}+==  LIST DEPARTMENTS & ROLES  =============================+{Environment.NewLine}");
                        DisplayTable.TableDepartments(departments);
                        DisplayTable.TableRoles(roles);
                        break;
                    case '4':
                        Console.WriteLine($"{Environment.NewLine}+==  List of Employees in specified Department  ============+{Environment.NewLine}");
                        DisplayTable.TableDepartmentEmployees(departments);
                        break;
                    case '5':
                        Console.WriteLine($"{Environment.NewLine}+==  Add Employee (Non-persistant) =========================+{Environment.NewLine}");
                        Employee emp = CaptureData.CaptureEmployee(roles);
                        CreateData.AddEmployee(employees, emp);
                        DisplayTable.TableDepartments(departments);
                        int departmentId = CaptureData.CaptureDepartmentId(departments);
                        CreateData.AssignEmployeeToDepartment(employees, departments, departmentId);
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

        public static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                $"+=======================  MAIN MENU  =======================+{Environment.NewLine}" +
                $"|  Press '1' Company Details                                |{Environment.NewLine}" +
                $"|  Press '2' List All Employees                             |{Environment.NewLine}" +
                $"|  Press '3' List Departments & Roles                       |{Environment.NewLine}" +
                $"|-----------------------------------------------------------|{Environment.NewLine}" +
                $"|  Press '4' List Employees in Department                   |{Environment.NewLine}" +   
                $"|  Press '5' Add Employee (Non-persistant)                  |{Environment.NewLine}" +
                $"|-----------------------------------------------------------|{Environment.NewLine}" +
                $"|  Press 'R' Reset the screen                               |{Environment.NewLine}" +
                $"|  Press 'Q' to quit the program                            |{Environment.NewLine}" +
                $"+===========================================================+"
                );
            Console.ResetColor();
        }
    }
}
