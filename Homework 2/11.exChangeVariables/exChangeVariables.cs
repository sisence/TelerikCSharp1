﻿// Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;


class exChangeVariables
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c = a;
            a = b;
            b = c;

        Console.WriteLine("a = {0}, b = {1}", a, b);
    }
}

