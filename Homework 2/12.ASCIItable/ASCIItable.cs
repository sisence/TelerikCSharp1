//Write a program that prints the entire ASCII table of characters on the console

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ASCIItable
{
    static void Main()
    {
        Console.Title = "ASCII Table";

        for (int c = 0; c < 127; c++)
        {
            Console.WriteLine("Character: {0} = {1}", c, (char)c);
        }
    }
}

