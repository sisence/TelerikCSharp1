﻿/*A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 
 *BIC code and 3 credit card numbers associated with the account. 
 *Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.*/

using System;

class BankAccount
{
    static void Main()
    {
        Console.WriteLine("Enter your first name:");
        string firstName = Console.ReadLine();
        
        Console.WriteLine("Enter your middle name");
        string middleName = Console.ReadLine();
        
        Console.WriteLine("Enter your last name");
        string lastName = Console.ReadLine();

        Console.WriteLine("Your first name is: {0}\nYour middle name is: {1}\nYour last name is: {2}", firstName, middleName, lastName);
        
        string theNameOfTheBank = "PostBank";
        Console.WriteLine("Your bank is {0}", theNameOfTheBank);
        
        decimal balanceOfMoney = 2000;
        Console.WriteLine("Available bank balance: {0}lv", balanceOfMoney);
        
        string iBan = "BGN07FFUU87003456735671";
        Console.WriteLine("IBAN / {0}", iBan);
        
        string bicCode = "BIC43562";
        Console.WriteLine("BIC CODE / {0}", bicCode);
        
        ulong creditCard1 = 548399274224422;
        Console.WriteLine("The number of your first credit card is: {0}", creditCard1);
        
        ulong creditCard2 = 1199886543214587;
        Console.WriteLine("The number of your second credit card is: {0}", creditCard2);
        
        ulong creditCard3 = 5432156789004012;
        Console.WriteLine("The number of your third credit card is: {0}", creditCard3);
    }
}

