using System;

//  вход            изход
//  2	            111112 111121 111211 112111 121111 211111
//
//  Пример: „Магическо число“ -> 2
//  •	111112 -> 1 * 1 * 1 * 1 * 1 * 2 = 2
//  •	111121 -> 1 * 1 * 1 * 1 * 2 * 1 = 2
//  •	111211 -> 1 * 1 * 1 * 2 * 1 * 1 = 2
//  •	112111 -> 1 * 1 * 2 * 1 * 1 * 1 = 2
//  •	121111 -> 1 * 2 * 1 * 1 * 1 * 1 = 2
//  •	211111 -> 2 * 1 * 1 * 1 * 1 * 1 = 2


class MagicCombination
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int m = 1; m <= 9; m++)
                        {
                            for (int s = 1; s <= 9; s++)
                            {
                                int product = i * j * k * l * m * s;

                                if (n == product)
                                {
                                    Console.Write("{0}{1}{2}{3}{4}{5} ", i, j, k, l, m, s);
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine();
    }
}