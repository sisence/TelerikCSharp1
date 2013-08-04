//4. Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class FactorialDivision
{
    static void Main()
    {
        Console.Write("Please enter number N, which is 1<K<N : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter number K, whick is 1<K<N : ");
        int k = int.Parse(Console.ReadLine());

        BigInteger result = 1;

        for (int i = k+1; i <= n; i++) //razlikata na (N-K)!
        {
            result *= i;
        }
        Console.WriteLine(result);
    }
}

