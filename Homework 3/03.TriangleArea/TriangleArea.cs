//Write an expression that calculates rectangle’s area by given width and height.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is the width of the triangle: ");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the height of the triangle: ");
        int height = int.Parse(Console.ReadLine());
        
        Console.WriteLine("The area of the triangle is {0} cm2.",width * height);
    }
}

