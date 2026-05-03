using CSharpExercises.Constants.ErrorMessages;

namespace CSharpExercises.Common.InputHelper
{
    public static class InputHelper
    {
        public static int GetIntMenuInput(string menuMsg, int min, int max)
        {
            while (true)
            {
                Console.WriteLine(menuMsg);
                string userInput = Console.ReadLine() ?? "";

                if (int.TryParse(userInput, out int inputValue))
                {
                    if (inputValue >= min && inputValue <= max) 
                        return inputValue;
                }

                Console.WriteLine(ErrorMessages.InvalidMsg);
            }
        }
    }
}
