//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.


using System;

class ExtractBitValue
{
    static void Main()
    {
        Console.WriteLine("Please enter integer i: ");
        int i = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the postion of the bit that you want to extact: ");
        int p = int.Parse(Console.ReadLine());

        int mask = (1 << p); // sets a mask with 1 at position p
        int maskResult = i & mask;

        int bit = maskResult >> p;

        Console.WriteLine("The bit on position {0} is: {1}", p, bit);
    }
}

