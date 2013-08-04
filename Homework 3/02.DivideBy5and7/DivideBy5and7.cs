//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class DivideBy5and7
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool div5 = (number % 5) == 0;
        bool div7 = (number % 7) == 0;

        if (div5 == true && div7 == true)
        {
            Console.WriteLine("The number can be divided by 5 and 7");
        }
        else
        {
            Console.WriteLine("The number cannot be divided by 5 and 7");
        }      
    }
}

