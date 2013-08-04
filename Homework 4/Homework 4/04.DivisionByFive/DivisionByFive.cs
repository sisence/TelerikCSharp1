//4. Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that 
//the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter the minimum number: ");
        int min = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the maximum number: ");
        int max = int.Parse(Console.ReadLine());

        int i;
        int result = 0;

        for ( i = min; i <= max; i++)
        {
	        if (i % 5 == 0)
	           {
                   result++;
	           } 
        }
        Console.WriteLine(result);
    }
}

