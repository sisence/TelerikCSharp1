using System;

class MyAge
    {
        static void Main()
        {
            Console.Write("My age now:");
            int Age = int.Parse(Console.ReadLine());
            Age += 10;
            Console.WriteLine("My age after ten years:" + Age);
        }
    }

