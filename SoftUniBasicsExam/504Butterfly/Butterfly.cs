using System;

// вход	                        изход
// 7	                        *****\ /*****
//                              -----\ /-----
//                              *****\ /*****
//                              -----\ /-----
//                              *****\ /*****
//                                    @
//                              *****/ \*****
//                              -----/ \-----
//                              *****/ \*****
//                              -----/ \-----
//                              *****/ \*****

class Butterfly
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int stars = n - 2;
        int dash = n - 2;

        for (int i = 0; i < n - 2; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(new string('*', stars));
                Console.Write(new string('\\', 1));
                Console.Write(new string(' ', 1));
                Console.Write(new string('/', 1));
                Console.Write(new string('*', stars));
                Console.WriteLine();
            }
            else
            {
                Console.Write(new string('-', dash));
                Console.Write(new string('\\', 1));
                Console.Write(new string(' ', 1));
                Console.Write(new string('/', 1));
                Console.Write(new string('-', dash));
                Console.WriteLine();
            }
        }

        Console.Write(new string(' ', n-1));
        Console.Write(new string('@', 1));
        Console.Write(new string(' ', n-1));
        Console.WriteLine();

        for (int i = 0; i < n - 2; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(new string('*', stars));
                Console.Write(new string('/', 1));
                Console.Write(new string(' ', 1));
                Console.Write(new string('\\', 1));
                Console.Write(new string('*', stars));
                Console.WriteLine();
            }
            else
            {
                Console.Write(new string('-', dash));
                Console.Write(new string('/', 1));
                Console.Write(new string(' ', 1));
                Console.Write(new string('\\', 1));
                Console.Write(new string('-', dash));
                Console.WriteLine();
            }
        }

    }
}