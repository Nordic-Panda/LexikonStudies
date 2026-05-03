using CSharpExercises.Common.InputHelper;
using CSharpExercises.Constants.ErrorConstants;
using CSharpExercises.Constants.MenuConstants;
using CSharpExercises.Constants.PriceConstants;
using CSharpExercises.Interfaces;

namespace CSharpExercises.Exercises.Exercise2
{
    internal class Exercise2 : IExercise
    {
        private const int _minAge = 0;
        private const int _maxAge = 150;
        private const int _youthTicketPrice = 80;
        private const int _seniorTicketPrice = 90;
        private const int _standardTicketPrice = 120;

        private const int _repeatCount = 10;

        private const int _wordToSelect = 3;

        public void Run()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine(MenuConstants.MenuSeparator);
                Console.WriteLine("     Welcome to Exercise 2 - Flow Control With Loops and Strings");
                Console.WriteLine(MenuConstants.MenuSeparator);

                Console.WriteLine("1. Youth or Senior");
                Console.WriteLine("   - Check ticket type depending on age");
                Console.WriteLine("   - Supports both single and group tickets");
                Console.WriteLine("2. Repeat 10 times");
                Console.WriteLine("   - UserInput will be repeated 10 times with loop");
                Console.WriteLine("3. The third word");
                Console.WriteLine("   - User enters a long string with spaces (at least 3 words)");
                Console.WriteLine("   - String will be splited and 3rd word will be shown");
                Console.WriteLine(MenuConstants.ReturnToMain); 

                int userChoice = InputHelper.GetIntInput(MenuConstants.SelectAnOption, 0, 3, ErrorConstants.InvalidMsg);

                switch (userChoice)
                {
                    case 1:
                        YouthOrSenior();
                        break;
                    case 2:
                        RepeatUserInput();
                        break;
                    case 3:
                        SplitString();
                        break;
                    case 0:
                        running = false;
                        break;
                    default:
                        Console.WriteLine(ErrorConstants.InvalidMsg);
                        break;
                }

            }
        }

        private static void YouthOrSenior() 
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine(MenuConstants.MenuSeparator);
                Console.WriteLine("     Welcome to exercise 2.1 - Youth Or Senior");
                Console.WriteLine(MenuConstants.MenuSeparator);

                Console.WriteLine("Ticket type:");
                Console.WriteLine("1. Single ticket");
                Console.WriteLine("2. Group ticket");
                Console.WriteLine(MenuConstants.ReturnToExercise);

                int userChoice = InputHelper.GetIntInput(MenuConstants.SelectAnOption, 0, 2, ErrorConstants.InvalidMsg);

                switch (userChoice)
                {
                    case 1:
                        GetSingleTicketPrice();
                        break;
                    case 2:
                        GetGroupTicketPrice();
                        break;
                    case 0:
                        running = false;
                        break;
                    default:
                        Console.WriteLine(ErrorConstants.InvalidMsg);
                        break;
                }
            }
        }

        private static void GetSingleTicketPrice() 
        {
            int age = InputHelper.GetIntInput(MenuConstants.EnterAge, _minAge, _maxAge, ErrorConstants.AgeInvalidMsg);
            string message = GetTicketMessageByAge(age);
            Console.WriteLine(MenuConstants.MenuStarLine);
            Console.WriteLine(message);
            Console.WriteLine(MenuConstants.MenuStarLine);
        }

        private static int GetTicketPriceByAge(int age)
        {
            if (age < 20)
                return _youthTicketPrice;
            else if (age > 64)
                return _seniorTicketPrice; 
            else
                return _standardTicketPrice;
        }

        private static string GetTicketMessageByAge(int age)
        {
            if (age < 20)
                return PriceConstants.YouthPrice;

            if (age > 64)
                return PriceConstants.SeniorPrice;

            return PriceConstants.StandardPrice;
        }

        private static void GetGroupTicketPrice()
        {
            int sum = 0;
            int youthCount = 0;
            int seniorCount = 0;
            int standardCount = 0;
            int size = InputHelper.GetIntInput(MenuConstants.EnterGroupSize, 0, 10, ErrorConstants.GroupSizeInvalidMsg);

            if (size == 1)
            {
                Console.WriteLine(ErrorConstants.GroupSizeInvalidMsg);
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    int age = InputHelper.GetIntInput($"Age for customer {i + 1}:", _minAge, _maxAge, ErrorConstants.AgeInvalidMsg);
                    int price = GetTicketPriceByAge(age);
                    sum += price;

                    if (age < 20)
                        youthCount++;
                    else if (age > 64)
                        seniorCount++;
                    else
                        standardCount++;
                }

                Console.WriteLine(MenuConstants.MenuStarLine);
                Console.WriteLine("Tickets Summary:");
                Console.WriteLine($"Group size: {size}");
                Console.WriteLine($"Youth tickets ({_youthTicketPrice} kr): {youthCount}");
                Console.WriteLine($"Senior tickets ({_seniorTicketPrice} kr): {seniorCount}");
                Console.WriteLine($"Standard tickets ({_standardTicketPrice} kr): {standardCount}");
                Console.WriteLine($"{PriceConstants.TotalPrice} {sum} kr");
                Console.WriteLine(MenuConstants.MenuStarLine);
            }
        }

        private static void RepeatUserInput() 
        {
            string userInput = InputHelper.GetStringInput(MenuConstants.InputToRepeat, ErrorConstants.EmptyOrInvalidInputMsg);
            string output = "";
            for (int i = 0; i < _repeatCount; i++)
            {
                output += $"{i + 1}. {userInput}";

                // avoid having , on the last run
                if (i < _repeatCount - 1)
                    output += ", ";
            }

            Console.WriteLine(output);
        }

        private static void SplitString() 
        {
            var userInput = InputHelper.GetStringInput(MenuConstants.EnterThreeWords, ErrorConstants.EmptyOrInvalidInputMsg, 3);

            var stringArr = userInput.Split(" ");

            Console.WriteLine(MenuConstants.MenuStarLine);
            Console.WriteLine($"3rd word is: {stringArr[_wordToSelect - 1]}");
            Console.WriteLine(MenuConstants.MenuStarLine);
        }

    }
}
