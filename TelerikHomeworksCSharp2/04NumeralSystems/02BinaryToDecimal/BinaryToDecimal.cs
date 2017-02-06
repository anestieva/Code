using System;

// Write a program that converts a binary number N to its decimal representation.

class BinaryToDec
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        Console.WriteLine(BinaryToDecimal(binaryNumber));
    }

    static long BinaryToDecimal (string binary)
    {
        long sum = 0;

        foreach (char bit in binary)
        {
            sum = (bit - '0') + sum * 2;
        }
        return sum;
    }
}