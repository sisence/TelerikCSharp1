﻿//5.Declare a character variable and assign it with the symbol that has Unicode code 72. 

using System;

class CharacterVariable
{
    static void Main()
    {
        char symbolUnicode = '\u0048'; //the number 72 in hexadecimal format is 48
        Console.WriteLine("Symbol Unicode code 72 (hex 48) is {0} ", symbolUnicode);
    }
}


