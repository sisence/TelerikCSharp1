//6. Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

using System;

class BooleanVariable
{
    static void Main()
    {
        bool isFemale;
        Console.WriteLine("What is your gender (male/female):");
        string myGender = Console.ReadLine();

        if (myGender == "female")
        {
            isFemale = true;
        }
        else
        {
            isFemale = false;
        }

        Console.WriteLine("You are female: " + isFemale);
    }
}

