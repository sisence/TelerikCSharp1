//Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.

using System;

class BooleanExpression
{
    static void Main()
    {
        Console.WriteLine("Please enter number v:");
        int numV = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter bit position p: ");
        int p = int.Parse(Console.ReadLine()); //the position of the bit that we want to test

        int mask = (1 << p);

        int maskRresult = numV & mask;

        int endValue = maskRresult >> p;

        bool finalResult = (endValue == 1);

        if (finalResult == true)
        {
            Console.WriteLine("The bit at position p is 1.");
        }
        else
        {
            Console.WriteLine("The bit at position p is 0.");
        }
    }
}

