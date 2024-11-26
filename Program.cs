// See https://aka.ms/new-console-template for more informations// See https://aka.ms/new-console-template for more information
using System;
using LessleyCalc;

// Example usage of the calculator
int GetNumberFromUser(string prompt)
{
    Console.Write(prompt);
    string input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        Environment.Exit(1);
    }
    return int.Parse(input);
}

int a = GetNumberFromUser("Enter the first number: ");
int b = GetNumberFromUser("Enter the second number: ");

var calc = new Calculator();
int sum = calc.Add(a, b);
int difference = calc.Subtract(a, b);
int product = calc.Multiply(a, b);
int quotient = calc.Divide(a, b);

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
