//2. Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third number: ");
            int c = int.Parse(Console.ReadLine());

            if ((a < 0 && b < 0 && c < 0) || (a > 0 && b > 0 && c < 0) || (a > 0 && b < 0 && c > 0) || (a < 0 && b > 0 && c > 0))
            {
                Console.WriteLine("The sign of the product of three numbers is '-' ");   
            }
            else
            {
                Console.WriteLine("The sign of the product of three numbers is '+' "); 
            }

        }
    }
