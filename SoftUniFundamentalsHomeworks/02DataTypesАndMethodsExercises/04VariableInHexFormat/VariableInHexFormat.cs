using System;

class VariableInHexFormat
{
    static void Main()
    {
        string input = Console.ReadLine();

        int inHexFormat = Convert.ToInt32(input, 16);

        Console.WriteLine(inHexFormat);
    }
}