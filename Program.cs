// See https://aka.ms/new-console-template for more informations// See https://aka.ms/new-console-template for more information
using System;
using Calculator;

// Example usage of the calculator
Console.Writes("Enter the first number: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
int b = int.Parse(Console.ReadLine());

var calc = new Calculator.Calculator();
int sum = calc.Add(a, b);
int difference = calc.Subtract(a, b);
int product = calc.Multiply(a, b);
int quotient = calc.Divide(a, b);

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
