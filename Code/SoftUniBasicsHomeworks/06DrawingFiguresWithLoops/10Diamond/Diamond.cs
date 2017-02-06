using System;

//  5
//  --*--
//  -*-*-
//  *---*
//  -*-*-
//  --*--

class Diamond
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = 0;
        if (n % 2 != 0)
        {
            k = 1;
        }

        for (int i = 0; i < n / 2 + k; i++)
        {
            if (n % 2 == 0)
            {
                Console.Write(new string('-', (n / 2) - 1 - i));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', 2 * i));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', (n / 2) - 1 - i));
                Console.WriteLine();
            }
            else
            {
                if (i == 0)
                {
                    Console.Write(new string('-', (n / 2)));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', (n / 2)));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string('-', (n / 2) - i));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', 2 * i - 1));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', (n / 2) - i));
                    Console.WriteLine();
                }
            }
        }

        for (int i = 0; i < n / 2 - 1 + k; i++)
        {

            if (n % 2 == 0)
            {
                Console.Write(new string('-', 1 + i));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', n - 4 - 2 * i));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', 1 + i));
                Console.WriteLine();
            }
            else
            {
                if (i == n / 2 - 1)
                {
                    Console.Write(new string('-', (n - 1) / 2));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', (n - 1) / 2));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string('-', 1 + i));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', n - 4 - 2 * i));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', 1 + i));
                    Console.WriteLine();
                }
            }
        }
    }
}