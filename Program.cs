﻿using System;

public class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Júlio", DateOnly.Parse("2000/07/09") , "538.123.141-40", Gender.Male);
        Customer customer2 = new Customer("Júlia", DateOnly.Parse("1990/01/06"), "896-123-543-10", Gender.Female);

        Bank digicoinBank = new Bank("Digicoin");

        AccountSavings accS1 = new AccountSavings(digicoinBank, customer1);
        CheckingAccount accC1 =  new CheckingAccount (digicoinBank, customer2);

        Console.WriteLine(customer1);
        Console.WriteLine(accS1);
        Console.WriteLine(digicoinBank);

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        
        accC1.ShowData(customer2, digicoinBank);
    }
}