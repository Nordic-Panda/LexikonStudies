using CSharpExercises.Common.InputHelper;
using CSharpExercises.Constants.ErrorMessages;
using CSharpExercises.Constants.MenuMessages;
using CSharpExercises.Exercises.Exercise1;
using CSharpExercises.Exercises.Exercise1.Services;
using CSharpExercises.Exercises.Exercise2;
using CSharpExercises.Interfaces;

// For showing swedish letters
Console.OutputEncoding = System.Text.Encoding.UTF8;

var employeeService = new EmployeeService();

while (true)
{
    Console.WriteLine(MenuMessages.MenuHeaderLine);
    Console.WriteLine("     C# Exercises Menu");
    Console.WriteLine(MenuMessages.MenuHeaderLine);
    
    Console.WriteLine("1. Exercise 1 - Restaurant Register");
    Console.WriteLine("2. Exercise 2 - Flow Control With Loops and Strings");
    Console.WriteLine("0. Exit");

    int userChoice = InputHelper.GetIntInput(MenuMessages.SelectAnOption, 0, 2, ErrorMessages.InvalidMsg);

    IExercise ex = null;

    switch (userChoice)
    {
        case 1:
            ex = new Exercise1(employeeService);
            break;

        case 2:
            ex = new Exercise2();
            break;

        case 0:
            return;

        default:
            Console.WriteLine(ErrorMessages.InvalidMsg);
            break;
    }

    ex?.Run();
}