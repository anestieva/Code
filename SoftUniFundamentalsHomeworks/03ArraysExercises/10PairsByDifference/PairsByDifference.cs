using System;
using System.Linq;

//  Програма, която изчислява подадена разлика между числа в масив и съответно колко пъти я има
//
//  Вход             Изход              Обяснение
//  1 5 3 4 2        3                  Pairs of elements with difference 2 -> {1, 3}, {5, 3}, {4, 2}
//  2		


class PairsByDifference
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int difference = int.Parse(Console.ReadLine());

        int foundDifference = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                int currentDifference = numbers[i] - numbers[j];

                if (difference == currentDifference)
                {
                    foundDifference++;
                }
            }
        }
        Console.WriteLine(foundDifference);
    }
}