//4. Sort 3 real values in descending order using nested if statements.


using System;


class SortRealValues
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
                if (b > c)
                {
                    Console.WriteLine("{0} > {1} > {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} > {1} > {2}", a, c, b);
                }
            }
            else
            {
                    Console.WriteLine("{0} > {1} > {2}", c, a, b);
            }
        }
        else
        {
            if (b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("{0} > {1} > {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0} > {1} > {2}", b, c, a);
                }
            }
            else
            {
                Console.WriteLine("{0} > {1} > {2}", c, b, a);
            }
       
        }
    }
}
