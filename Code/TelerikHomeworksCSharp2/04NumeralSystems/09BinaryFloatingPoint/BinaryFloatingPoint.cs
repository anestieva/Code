using System;
using System.Globalization;
using System.Threading;

// Write a program that shows the internal binary representation of given 32-bit signed floating-point number 
// in IEEE 754 format (the C# type float).

class BinaryFloatingPoint
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter floating-point number: ");
        float number = float.Parse(Console.ReadLine());

        int sign = number > 0 ? 0 : 1;
        number = Math.Abs(number);
        string inBinary = FloatToBinary(number);

        if ((int)number == 0 || (int)number == 1)
        {
            inBinary = "0" + inBinary;
        }

        Console.WriteLine("Sign: " + sign);
        Console.WriteLine("Exponent: " + GetExponent(inBinary));
        Console.WriteLine("Mantissa: " + GetMantissa(inBinary));
    }

    static string FloatToBinary(float number)
    {
        int intNumber = BitConverter.ToInt32(BitConverter.GetBytes(number), 0);
        return Convert.ToString(intNumber, 2);
    }

    static string GetExponent(string inBinary)
    {
        return inBinary.Substring(0, 8);
    }

    static string GetMantissa(string inBinary)
    {
        return inBinary.Substring(8);
    }
}