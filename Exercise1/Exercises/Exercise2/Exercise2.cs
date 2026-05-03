using CSharpExercises.Common.InputHelper;
using CSharpExercises.Constants.ErrorMessages;
using CSharpExercises.Constants.MenuMessages;
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
                Console.WriteLine(MenuMessages.MenuSeparator);
                Console.WriteLine("     Welcome to Exercise 2 - Flow Control With Loops and Strings");
                Console.WriteLine(MenuMessages.MenuSeparator);

                Console.WriteLine("1. Youth or Senior");
                Console.WriteLine("2. Repeat 10 times");
                Console.WriteLine("3. The third word");
                Console.WriteLine(MenuMessages.ReturnToMain); 

                int userChoice = InputHelper.GetIntMenuInput(MenuMessages.SelectAnOption, 0, 3);

                switch (userChoice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
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
    }
}
