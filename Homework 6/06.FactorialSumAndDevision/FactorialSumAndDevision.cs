﻿//06. Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

using System;

class FactorialSumAndDevision
{
    static void Main()
    
    {
        Console.Write("Please enter n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter x= ");
        int x = int.Parse(Console.ReadLine());
        
        decimal resultX = 1;
        decimal factorialN = 1;
        decimal sum = 0;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            resultX *= x;
            sum += (factorialN / resultX);
        }
        Console.WriteLine(1 + sum);
    }
}

