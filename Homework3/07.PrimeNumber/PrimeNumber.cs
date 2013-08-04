//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeNumber
{
    static void Main()
    {
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Checks if given positive integer number n (n < 100) is prime?");
           
           int number = int.Parse(Console.ReadLine());
           
           bool check1 = (number % 2 > 0) && (number % 3 > 0) && (number % 5 > 0) && (number % 7 > 0) || (number == 2) || (number == 3) || (number == 5) || (number == 7);
           
           Console.WriteLine(check1);
           if (check1 == true)
           {
               Console.WriteLine("The number is prime");
           }
           else
           {
               Console.WriteLine("The number is NOT prime");
           }
        }

    }
}

