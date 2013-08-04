//8. Declare two string variables and assign them with following value:
//The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings.


using System;

class TwoStringsDifferentWays
{
    static void Main()
    {
        Console.WriteLine(new string('-', 50));

        Console.WriteLine("First variant:");
        string firstWay = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(firstWay);

        Console.WriteLine(new string('-', 50));

        Console.WriteLine("Second variant:");
        string secondWay = @"The ""use"" of quotations causes difficulties(2).";
        Console.WriteLine(secondWay);

        Console.WriteLine(new string('-', 50));
    }
}

