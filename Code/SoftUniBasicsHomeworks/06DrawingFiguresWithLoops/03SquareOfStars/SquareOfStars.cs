using System;

//  4
//  ****
//  ****
//  ****
//  ****

class SquareOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write('*');
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}