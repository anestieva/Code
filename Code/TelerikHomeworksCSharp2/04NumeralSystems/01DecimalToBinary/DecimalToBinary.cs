using System;

// Write a program that converts a decimal number N to its binary representation.

// long number = long.Parse(Console.ReadLine());
// string binary = Convert.ToString(number, 2);

class DecToBinary
{
    static void Main()
    {
        long dec = long.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToBinary(dec));
    }

    static string DecimalToBinary (long decValue)
    {
        string binary = "";

        while (decValue > 0)
        {
            long bit = decValue % 2;
            binary = bit + binary;
            decValue /= 2;
        }
        return binary;
    }
}