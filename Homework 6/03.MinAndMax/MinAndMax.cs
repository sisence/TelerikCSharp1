//3. Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class Program
{
    static void Main()
    {
        Console.Write("How many numbers do you want to compare: ");
        int n = int.Parse(Console.ReadLine());

        int min = int.MinValue;
        int max = 0;

        for (int i = 1; i < n+1; i++)
        {
            Console.Write("Enter a number {0}: ",i);
            int variable = int.Parse(Console.ReadLine());

            if (i==1)
            {
                min = variable;
                max = variable;
            }
            if (variable > max)
            {
                max = variable;
            }
            if (variable < min)
            {
                min = variable;
            }
        }
        Console.WriteLine("The minimum number of the sequence is {0} ",min);
        Console.WriteLine("The maximum number of the sequence is {0} ", max);
    }
}

