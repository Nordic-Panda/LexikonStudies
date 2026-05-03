using CSharpExercises.Constants.ErrorMessages;
using CSharpExercises.Exercises.Exercise1;
using CSharpExercises.Exercises.Exercise1.Services;
using CSharpExercises.Exercises.Exercise2;
using CSharpExercises.Interfaces;

var employeeService = new EmployeeService();

while (true)
{
    Console.WriteLine("=================================");
    Console.WriteLine("     C# Exercises Menu");
    Console.WriteLine("=================================");
    Console.WriteLine("1. Exercise 1 - Restaurant Register");
    Console.WriteLine("2. Exercise 2 - Flow Control With Loops and Strings");
    Console.WriteLine("0. Exit");

    if (!int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.WriteLine(ErrorMessages.InvalidMsg);
        continue;
    }

    IExercise ex = null;

    switch (choice)
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