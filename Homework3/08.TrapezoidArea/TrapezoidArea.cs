//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;


class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Please enter the length of side a of the trapezoid: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the length of side b of the trapezoid: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the heigt of the trapezoid: ");
        double height = double.Parse(Console.ReadLine());

        double areaTrapezoid = ((sideA + sideB)/2)*height;
        Console.WriteLine("The area of the trapezoid is {0} cm2.",areaTrapezoid);
    }
}

