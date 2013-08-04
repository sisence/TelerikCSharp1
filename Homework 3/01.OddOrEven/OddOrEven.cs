//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        string str = Console.ReadLine();

        while (str != "exit")
        {
            int number = int.Parse(str);


            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("Then number is odd");
            }

            Console.WriteLine("____________");
            Console.WriteLine("Please enter a number: ");
            str = Console.ReadLine();
        }
    }
}

