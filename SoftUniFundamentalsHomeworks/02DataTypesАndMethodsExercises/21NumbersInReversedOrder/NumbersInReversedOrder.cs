using System;

class NumbersInReversedOrder
{
    static void Main()
    {
        string input = Console.ReadLine();

        Reversed(input);
    }

    private static void Reversed(string input)
    {
        for (int i = input.Length -1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
        Console.WriteLine();
    }
}