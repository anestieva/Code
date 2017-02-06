﻿using System;

// Write a method that asks the user for his name and prints Hello, <name>!. Write a program to test this method.

public class SayHello
{
    public static void Main()
    {
        // input
        string name = Console.ReadLine();

        // calling the method
        Console.WriteLine(PrintName(name));
    }


    //declaring the method
    public static string PrintName(string someName)
    {
        return string.Format("Hello, {0}!", someName);
    }
}