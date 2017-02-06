using System;

class DrawFort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write(new string('/', 1));
        Console.Write(new string('^', n / 2));
        Console.Write(new string('\\', 1));
        Console.Write(new string('_', n * 2 - 4 - 2 * (n / 2)));
        Console.Write(new string('/', 1));
        Console.Write(new string('^', n / 2));
        Console.Write(new string('\\', 1));
        Console.WriteLine();

        for (int i = 0; i < n - 3; i++)
        {
            Console.Write(new string('|', 1));
            Console.Write(new string(' ', 2 + n + (n - 4)));
            Console.Write(new string('|', 1));
            Console.WriteLine();
        }

        Console.Write(new string('|', 1));
        Console.Write(new string(' ', n / 2 + 1));
        Console.Write(new string('_', n * 2 - 4 - 2 * (n / 2)));
        Console.Write(new string(' ', n / 2 + 1));
        Console.Write(new string('|', 1));
        Console.WriteLine();

        Console.Write(new string('\\', 1));
        Console.Write(new string('_', n / 2));
        Console.Write(new string('/', 1));
        Console.Write(new string(' ', n * 2 - 4 - 2 * (n / 2)));
        Console.Write(new string('\\', 1));
        Console.Write(new string('_', n / 2));
        Console.Write(new string('/', 1));
        Console.WriteLine();

    }
}