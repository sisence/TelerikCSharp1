//02. Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please enter the radius of the circle: ");
        
        double radius = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double perimeter = 2 * pi * radius;
        
        Console.WriteLine("The perimeter of the circle is {0:.00} ", perimeter);

        double area = pi * radius * radius;

        Console.WriteLine("The area of the circle is {0:.00} ", area);

    }
}

