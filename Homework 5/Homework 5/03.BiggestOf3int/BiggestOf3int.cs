//3. Write a program that finds the biggest of three integers using nested if statements.

using System;

class BiggestOf3int
{
    static void Main()
    {
        Console.WriteLine("Please enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the third number: ");
        int c = int.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("The biggest number is {0} ",a); 
            }
            else
            {
                Console.WriteLine("The biggest number is {0} ",c);
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("The biggest number is {0} ",b);
            }
            else
            {
                Console.WriteLine("The biggest number is {0} ", c);
            }
        }
    }
}

