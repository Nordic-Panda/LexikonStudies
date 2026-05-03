using CSharpExercises.Constants.ErrorMessages;
using CSharpExercises.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercises.Exercises.Exercise2
{
    internal class Exercise2 : IExercise
    {
        public void Run()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("     Welcome to Exercise 2 - Flow Control With Loops and Strings");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Please select from below menu (0-3):");
                Console.WriteLine("1. Youth or Senior");
                Console.WriteLine("2. Repeat 10 times");
                Console.WriteLine("3. The third word");
                Console.WriteLine("0. Return to main menu");

                string userMenuInput = Console.ReadLine();

                //if (int.TryParse(userMenuInput, out int userChoice))
                //{
                //    if (userChoice >= 0 && userChoice <= 4)
                //    {
                //        switch (userChoice)
                //        {
                //            case 1:
                //                ShowEmployees();
                //                break;
                //            case 2:
                //                AddEmployee();
                //                break;
                //            case 3:
                //                EditEmployee();
                //                break;
                //            case 4:
                //                RemoveEmployee();
                //                break;
                //            case 0:
                //                running = false;
                //                break;
                //            default:
                //                Console.WriteLine(ErrorMessages.InvalidMsg);
                //                break;
                //        }

                //    }
                //    else
                //    {
                //        Console.WriteLine(ErrorMessages.InvalidMsg);
                //    }

                //}
                //else
                //{
                //    Console.WriteLine(ErrorMessages.InvalidMsg);
                //}


            }
        }
    }
}
