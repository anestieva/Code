using System;

class SquareOfStars
{
    static void Main()
    {
        int dash = int.Parse(Console.ReadLine());

        Console.Write(new string('*', dash));
        Console.WriteLine();

        for (int i = 0; i < dash - 2; i++)
        {
            int empty = dash - 2;
            Console.Write('*');
            Console.Write(new string(' ', empty));
            Console.Write('*');
            Console.WriteLine();
        }

        Console.Write(new string('*', dash));
        Console.WriteLine();
    }
}