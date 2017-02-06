using System;
using System.Numerics;

// Write a method that multiplies a number represented as an array of digits by a given integer number. 
// Write a program to calculate N!.

public class NFactorial
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(Factorial(number));
    }

    static BigInteger Factorial(int number)
    {
        BigInteger result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }
}
