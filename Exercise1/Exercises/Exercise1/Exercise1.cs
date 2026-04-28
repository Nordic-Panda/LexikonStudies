using CSharpExercises.Exercises.Exercise1.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercises.Exercises.Exercise1
{
    internal class Exercise1
    {
        private readonly EmployeeService _employeeService;
        private readonly string _invalidMsg = "Invalid choice. Please choose from menu";
        private readonly string _emptyOrInvalidInputMsg = "Empty or Invalid input. Please enter valid value";
        private readonly string _employeeNotFoundMsg = "Employee not found. Please enter an valid index";

        public Exercise1(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public void Run()
        {
            Console.WriteLine("Welcome to Exercise 1 - Restaurant Register");
            Console.WriteLine("Please select from below menu (1-4):");
            Console.WriteLine("1. Show all employees info");
            Console.WriteLine("2. Add an employee");
            Console.WriteLine("3. Edit an employee");
            Console.WriteLine("4. Remove an employee");

            string userMenuInput = Console.ReadLine();

            if (int.TryParse(userMenuInput, out int userChoice))
            {
                if (userChoice >= 1 && userChoice <= 4)
                {
                    switch (userChoice)
                    {
                        case 1:
                            ShowEmployees();
                            break;
                        case 2:
                            AddEmployee();
                            break;
                        case 3:
                            EditEmployee();
                            break;
                        case 4:
                            RemoveEmployee();
                            break;
                        default:
                            Console.WriteLine(_invalidMsg);
                            break;
                    }

                }
                else
                {
                    Console.WriteLine(_invalidMsg);
                }

            }
            else
            {
                Console.WriteLine(_invalidMsg);
            }



        }

        private void ShowEmployees()
        {
            var employees = _employeeService.GetAllEmployees();

            for (int i = 0; i < employees.Count; i++)
            {
                var emp = employees[i];
                Console.WriteLine($"{i + 1}. {emp.FirstName} {emp.LastName} - {emp.Salary}");
            }
        }

        private void AddEmployee()
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(firstName))
            {
                Console.WriteLine(_emptyOrInvalidInputMsg);
                return;
            }

            Console.Write("Last name: ");
            string lastName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(lastName))
            {
                Console.WriteLine(_emptyOrInvalidInputMsg);
                return;
            }

            Console.Write("Salary: ");
            if (!int.TryParse(Console.ReadLine(), out int salary))
            {
                Console.WriteLine(_emptyOrInvalidInputMsg);
                return;
            }

            var isAdded = _employeeService.AddEmployee(firstName, lastName, salary);
            Console.WriteLine(isAdded ? "Add employee done!" : "Add employee failed!");
        }

        private void EditEmployee()
        {
            var employees = _employeeService.GetAllEmployees();

            ShowEmployees();

            Console.Write("Select employee to be edited: ");
            if (!int.TryParse(Console.ReadLine(), out int index))
            {
                Console.WriteLine(_employeeNotFoundMsg);
                return;
            }

            index = index - 1;

            if (index < 0 || index >= employees.Count)
            {
                Console.WriteLine(_employeeNotFoundMsg);
                return;
            }

            Console.Write("New first name: ");
            string firstName = Console.ReadLine();

            Console.Write("New last name: ");
            string lastName = Console.ReadLine();

            Console.Write("New salary: ");
            if (!int.TryParse(Console.ReadLine(), out int salary))
            {
                Console.WriteLine(_invalidMsg);
                return;
            }

            var isEdited = _employeeService.EditEmployee(firstName, lastName, salary, index);
            Console.WriteLine(isEdited ? "Edit employee done!" : "Edit employee failed!");
        }

        private void RemoveEmployee()
        {
            var employees = _employeeService.GetAllEmployees();

            ShowEmployees();

            Console.Write("Select employee to be removed: ");
            if (!int.TryParse(Console.ReadLine(), out int index))
            {
                Console.WriteLine(_employeeNotFoundMsg);
                return;
            }

            index = index - 1;

            if (index < 0 || index >= employees.Count)
            {
                Console.WriteLine(_employeeNotFoundMsg);
                return;
            }

            var isRemoved = _employeeService.RemoveEmployee(index);
            Console.WriteLine(isRemoved ? "Remove employee done!" : "Remove employee failed!");
        }
    }
}

