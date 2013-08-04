//5. Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class PrintGreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("The bigger number is {0}!", (number1 > number2 ? number1 : number2));
    }
}

