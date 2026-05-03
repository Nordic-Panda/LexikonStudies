namespace CSharpExercises.Common.InputHelper
{
    public static class InputHelper
    {
        public static int GetIntInput(string menuMsg, int min, int max, string errMsg)
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

                Console.WriteLine(errMsg);
            }
        }

        public static string GetStringInput(string menuMsg, string errMsg)
        {
            while (true) 
            {
                Console.WriteLine(menuMsg);
                string userInput = Console.ReadLine() ?? "";

                if (!String.IsNullOrWhiteSpace(userInput))
                { 
                    return userInput;
                }

                Console.WriteLine(errMsg);
            }
        }
    }
}
