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

        // default value on min and max, making them OPTIONAL
        public static string GetStringInput(string menuMsg, string errMsg, int min = 0, int max = 0)
        {
            while (true) 
            {
                Console.WriteLine(menuMsg);
                string userInput = Console.ReadLine() ?? "";
                userInput = userInput.Trim();

                if (!String.IsNullOrWhiteSpace(userInput))
                {
                    // we are using default value on min max
                    // ignores min max validation
                    if (min == 0 && max == 0)
                        return userInput;
                    
                    if (min != 0 && userInput.Split(" ").Length >= min)
                        return userInput;
                }

                Console.WriteLine(errMsg);
            }
        }
    }
}
