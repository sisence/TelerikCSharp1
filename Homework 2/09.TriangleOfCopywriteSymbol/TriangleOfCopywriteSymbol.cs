//9. Write a program that prints an isosceles triangle of 9 copyright symbols ©. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TriangleOfCopywriteSymbol
{
    static void Main()
    {
        char a = '\u00A9';

        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("\t  {0}", a);
        Console.WriteLine("\t {0}{0}{0}", a);
        Console.WriteLine("\t{0}{0}{0}{0}{0}", a);
    }
}
