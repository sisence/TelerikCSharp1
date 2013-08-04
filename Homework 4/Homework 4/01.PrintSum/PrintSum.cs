//01. Write a program that reads 3 integer numbers from the console and prints their sum.

using System;


class PrintSum
{
    static void Main()
    {
        Console.WriteLine("Please enter the first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the third number: ");
        int thirdNum = int.Parse(Console.ReadLine());

        int sum = firstNum + secondNum + thirdNum;

        Console.WriteLine("The sum of the three numbers is {0} ",sum);
    }
}

