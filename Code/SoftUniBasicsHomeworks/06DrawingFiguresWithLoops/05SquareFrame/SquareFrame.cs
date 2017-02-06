using System;

//  4
//  + - - +
//  | - - |
//  | - - |
//  + - - +

class SquareFrame
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write("+ ");
        for (int i = 0; i < n-2; i++)
        {
            Console.Write("- ");
        }
        Console.Write("+");
        Console.WriteLine();

        for (int j = 0; j < n-2; j++)
        {
            Console.Write("| ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("|");
            Console.WriteLine();
        }

        Console.Write("+ ");
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("- ");
        }
        Console.Write("+");
        Console.WriteLine();
    }
}