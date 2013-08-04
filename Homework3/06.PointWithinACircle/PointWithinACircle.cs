    //Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

    using System;

class PointWithinACircle
{
    static void Main()
    {
        int radius = 5;
        Console.Write("Enter the x cordinate for the point: x= ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter the y cordinate for the point: y= ");
        int y = int.Parse(Console.ReadLine());

        if (((x - 1)*(x - 1) + (y - 1)*(y - 1)) <= radius * radius)            //Formula for point to be in circle with O(0,0)
        {
            Console.WriteLine("The point is in the circle.");
        }
        else
        {
            Console.WriteLine("The point is NOT in the circle.");
        }
    }
}


