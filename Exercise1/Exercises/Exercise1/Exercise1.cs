using CSharpExercises.Common.InputHelper;
using CSharpExercises.Constants.ErrorMessages;
using CSharpExercises.Constants.MenuMessages;
using CSharpExercises.Exercises.Exercise1.Services;
using CSharpExercises.Interfaces;

namespace CSharpExercises.Exercises.Exercise1
{
    internal class Exercise1 : IExercise
    {
        private readonly EmployeeService _employeeService;

        public Exercise1(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public void Run()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine(MenuMessages.MenuSeparator);
                Console.WriteLine("     Welcome to Exercise 1 - Restaurant Register");
                Console.WriteLine(MenuMessages.MenuSeparator);
               
                Console.WriteLine("1. Show all employees info");
                Console.WriteLine("2. Add an employee");
                Console.WriteLine("3. Edit an employee");
                Console.WriteLine("4. Remove an employee");
                Console.WriteLine(MenuMessages.ReturnToMain);

                int userChoice = InputHelper.GetIntInput(MenuMessages.SelectAnOption, 0, 4, ErrorMessages.InvalidMsg);

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
                    case 0:
                        running = false;
                        break;
                    default:
                        Console.WriteLine(ErrorMessages.InvalidMsg);
                        break;
                }
            }



        }

        private void ShowEmployees()
        {
            var employees = _employeeService.GetAllEmployees();

            if (employees.Count == 0)
            {
                Console.WriteLine("No employee was found.");
            }
            else { 
                for (int i = 0; i < employees.Count; i++)
                {
                    var emp = employees[i];
                    Console.WriteLine($"{i + 1}. {emp.FirstName} {emp.LastName} - {emp.Salary}");
                }
            }
        }

        private void AddEmployee()
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(firstName))
            {
                Console.WriteLine(ErrorMessages.EmptyOrInvalidInputMsg);
                return;
            }

            Console.Write("Last name: ");
            string lastName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(lastName))
            {
                Console.WriteLine(ErrorMessages.EmptyOrInvalidInputMsg);
                return;
            }

            Console.Write("Salary: ");
            if (!int.TryParse(Console.ReadLine(), out int salary))
            {
                Console.WriteLine(ErrorMessages.EmptyOrInvalidInputMsg);
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
                Console.WriteLine(ErrorMessages.EmployeeNotFoundMsg);
                return;
            }

            index = index - 1;

            if (index < 0 || index >= employees.Count)
            {
                Console.WriteLine(ErrorMessages.EmployeeNotFoundMsg);
                return;
            }

            Console.Write("New first name: ");
            string firstName = Console.ReadLine();

            Console.Write("New last name: ");
            string lastName = Console.ReadLine();

            Console.Write("New salary: ");
            if (!int.TryParse(Console.ReadLine(), out int salary))
            {
                Console.WriteLine(ErrorMessages.InvalidMsg);
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
                Console.WriteLine(ErrorMessages.EmployeeNotFoundMsg);
                return;
            }

            index = index - 1;

            if (index < 0 || index >= employees.Count)
            {
                Console.WriteLine(ErrorMessages.EmployeeNotFoundMsg);
                return;
            }

            var isRemoved = _employeeService.RemoveEmployee(index);
            Console.WriteLine(isRemoved ? "Remove employee done!" : "Remove employee failed!");
        }
    }
}

