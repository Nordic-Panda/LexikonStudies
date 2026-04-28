using CSharpExercises.Exercises.Exercise1;
using CSharpExercises.Exercises.Exercise1.Services;

var employeeService = new EmployeeService();

string invalidMsg = "Invalid choice, please choose from menu";

while (true)
{
    Console.WriteLine("=================================");
    Console.WriteLine("     C# Exercises Menu");
    Console.WriteLine("=================================");
    Console.WriteLine("1. Exercise 1 - Restaurant Register");
    Console.WriteLine("0. Exit");

    if (!int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.WriteLine(invalidMsg);
        continue;
    }

    switch (choice)
    {
        case 1:
            var ex1 = new Exercise1(employeeService);
            ex1.Run();
            break;

        case 0:
            return;

        default:
            Console.WriteLine(invalidMsg);
            break;
    }
}