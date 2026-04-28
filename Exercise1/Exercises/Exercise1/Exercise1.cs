using CSharpExercises.Exercises.Exercise1.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercises.Exercises.Exercise1
{
    internal class Exercise1
    {
        private readonly EmployeeService _service;

        public Exercise1(EmployeeService service)
        {
            _service = service;
        }
        public void Run()
        {
            string invalidMsg = "Invalid choice. Please choose from menu (1-4)";

            Console.WriteLine("Welcome to Exercise 1 - Restaurant Register");
            Console.WriteLine("Please select from below menu (1-4):");
            Console.WriteLine("1. Show all employees info");
            Console.WriteLine("2. Add an employee");
            Console.WriteLine("3. Edit an employee");
            Console.WriteLine("4. Remove an employee");

            string userMenuInput = Console.ReadLine();

            if (int.TryParse(userMenuInput, out int userChoice))
            {
                if (userChoice >= 1 && userChoice <= 4) {
                    switch (userChoice) {
                        case 1:
                            var employees = _service.GetAllEmployees();
                            foreach (var emp in employees) {
                                Console.WriteLine($"Name: {emp.FirstName} {emp.LastName}, Salary: {emp.Salaray}");
                            }
                            break;
                        default:
                            Console.WriteLine(invalidMsg);
                            break;
                    }


                }
                else {
                    Console.WriteLine(invalidMsg);
                }

            }
            else {
                Console.WriteLine(invalidMsg);
            }



        }
    }
}
