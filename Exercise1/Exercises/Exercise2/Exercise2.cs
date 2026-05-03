using CSharpExercises.Common.InputHelper;
using CSharpExercises.Constants.ErrorMessages;
using CSharpExercises.Constants.MenuMessages;
using CSharpExercises.Constants.PriceMessages;
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

                int userChoice = InputHelper.GetIntInput(MenuMessages.SelectAnOption, 0, 3, ErrorMessages.InvalidMsg);

                switch (userChoice)
                {
                    case 1:
                        GetTicketPriceByAge();
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

        private void GetTicketPriceByAge() 
        {
            int age = InputHelper.GetIntInput(MenuMessages.EnterAge, 0, 150, ErrorMessages.AgeInvalidMsg);

            if (age < 20)
            {
                Console.WriteLine(PriceMessages.YouthPrice);
            }
            else if (age > 64)
            {
                Console.WriteLine(PriceMessages.SeniorPrice);
            }
            else 
            {
                Console.WriteLine(PriceMessages.StandardPrice);
            }
        }
    }
}
