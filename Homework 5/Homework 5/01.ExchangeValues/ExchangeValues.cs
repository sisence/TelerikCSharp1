//1. Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter the first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number: ");
        int secondNum = int.Parse(Console.ReadLine());

        int biggerNum = firstNum;

        if (secondNum > firstNum)
        {
            biggerNum = secondNum;
        }
        Console.WriteLine("The bigger number is {0} !", biggerNum);
    }
}

