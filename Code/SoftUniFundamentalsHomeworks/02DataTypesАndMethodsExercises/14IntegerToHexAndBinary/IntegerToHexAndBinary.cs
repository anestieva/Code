using System;

class IntegerToHexAndBinary
{
    static void Main()
    {
        int intValue = int.Parse(Console.ReadLine());

        // int to hex
        string hexValue = intValue.ToString("X");
        
        // int to bin
        int remainder;
        string binValue = string.Empty;
        while (intValue > 0)
        {
            remainder = intValue % 2;
            intValue /= 2;
            binValue = remainder.ToString() + binValue;
        }

        Console.WriteLine(hexValue);
        Console.WriteLine(binValue);
    }
}