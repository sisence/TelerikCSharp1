using System;


class ThirdBit
{
    static void Main()
    {
        Console.WriteLine("Please enter a number);
        string str = Console.ReadLine();
        int number = int.Parse(str);

        int p = 2;
        int mask = 1 << p;
        int nAndMask = number & mask;
        int bit = nAndMask >> p;

        Console.WriteLine("Third bit is: "+ bit);

    }
}

