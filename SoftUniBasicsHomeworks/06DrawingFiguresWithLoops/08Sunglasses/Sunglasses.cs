using System;

//  5
//  **********     **********
//  *////////*     *////////*
//  *////////*|||||*////////*
//  *////////*     *////////*
//  **********     **********

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int star = 2 * n;
        int space = n;
        int slash = 2 * n - 2;
        int line = n;

        Console.Write(new string('*', star));
        Console.Write(new string(' ', space));
        Console.Write(new string('*', star));
        Console.WriteLine();

        for (int i = 0; i < n - 2; i++)
        {
            star = 1;

            if (i == ((n - 1) / 2 - 1))
            {
                Console.Write(new string('*', star));
                Console.Write(new string('/', slash));
                Console.Write(new string('*', star));
                Console.Write(new string('|', line));
                Console.Write(new string('*', star));
                Console.Write(new string('/', slash));
                Console.Write(new string('*', star));
                Console.WriteLine();
            }
            else
            {
                Console.Write(new string('*', star));
                Console.Write(new string('/', slash));
                Console.Write(new string('*', star));
                Console.Write(new string(' ', space));
                Console.Write(new string('*', star));
                Console.Write(new string('/', slash));
                Console.Write(new string('*', star));
                Console.WriteLine();
            }
        }

        star = 2 * n;
        space = n;

        Console.Write(new string('*', star));
        Console.Write(new string(' ', space));
        Console.Write(new string('*', star));
        Console.WriteLine();

    }
}