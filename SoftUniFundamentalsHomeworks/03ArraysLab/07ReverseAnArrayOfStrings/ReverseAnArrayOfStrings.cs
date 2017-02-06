using System;

class ReverseAnArrayOfStrings
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(input);

        Console.WriteLine(string.Join(" ", input));
    }
}