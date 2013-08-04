//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class ThirdDigit7
{
    static void Main()
    {
        Console.WriteLine("Please write a number: ");
        string str = Console.ReadLine();
        int number = int.Parse(str);

        int firstResult = number / 100;
        int result = firstResult % 10;

        if (result == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        } 
 
    }
}

