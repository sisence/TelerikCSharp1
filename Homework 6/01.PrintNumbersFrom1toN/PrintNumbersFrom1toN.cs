//1. Write a program that prints all the numbers from 1 to N.


using System;

class PrintNumbersFrom1toN
{
    static void Main()
    {
        Console.WriteLine("Please enter a number N: ");
        int n = int.Parse(Console.ReadLine());
        int start = 1;
        Console.WriteLine(start);
        do
        {
            start++; 
            Console.WriteLine("{0}",start);
        } 
        while (start < n);
    }
}

