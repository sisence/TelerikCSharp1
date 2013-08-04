//13. * Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
//	N = 10 ---> N! = 3628800 ---> 2
//	N = 20 ---> N! = 2432902008176640000 ---> 4

using System;

class TrailingZeros
{
    static void Main()
    {
        Console.WriteLine("This calculates the trailing zeroes in N!.");
        Console.Write("Please write N = ");
        int n = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 5; i <= n; i *= 5)
        {
            result = result + (n / i);
        }
        Console.WriteLine("Trailing zeroes of {0}! are {1}.", n, result);
    }
}