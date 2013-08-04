//08. Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).


using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.Write("Please enter a= ");
        decimal a = decimal.Parse(Console.ReadLine());

        Console.Write("Please enter b= ");
        decimal b = decimal.Parse(Console.ReadLine());
        
        decimal temp = 0;

        if (a < b)  //Exchange values if a<b
        {
            temp = a;
            a = b;
            b = temp;
        }

        decimal result = 0;
        decimal reminder = 0;

        while (true)
        {
            result = a / b;
            reminder = a % b;

            if (reminder != 0)
            {
                Console.WriteLine("{0} : {1} = {2}; reminder = {3}",a,b,result,reminder);
                a = b;
                b = reminder;
            }
            else
            {
                Console.WriteLine("The Greatest Common Denominator is {0}", b);
                break;
            }
        }
    }
}

