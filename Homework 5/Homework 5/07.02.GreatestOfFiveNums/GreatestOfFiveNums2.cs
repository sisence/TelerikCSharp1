//7. Write a program that finds the greatest of given 5 variables.
// Second possible solution using arrays

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Please enter the first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        double thirdNum = double.Parse(Console.ReadLine());
        Console.Write("Please enter the fourth number: ");
        double fourthNum = double.Parse(Console.ReadLine());
        Console.Write("Please enter the fifth number: ");
        double fifthNum = double.Parse(Console.ReadLine());

        double[] fiveVariable = { firstNum, secondNum, thirdNum, fourthNum, fifthNum };

        double greatestNum = firstNum;

        for (int i = 0; i <= 4; i++)
        {
            if (fiveVariable[i] > greatestNum)
            {
                greatestNum = fiveVariable[i];
            }
        }
        Console.WriteLine("The greatest number is {0}!", greatestNum);
    }

}
