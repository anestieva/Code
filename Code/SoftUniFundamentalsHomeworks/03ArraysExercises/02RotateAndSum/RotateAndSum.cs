using System;
using System.Linq;

// Програма, която завърта масива определен брой пъти (последния става първи)
//
//  Вход                Изход                   Обяснение
//  1 2 3 4 5           12 10 8 6 9             rotated1[] =  5  1  2  3  4
//  3	                                        rotated2[] =  4  5  1  2  3
//                                              rotated3[] =  3  4  5  1  2
//                                              sum[] = 12 10  8  6  9

class RotateAndSum
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int k = int.Parse(Console.ReadLine());

        int[] rotateNumbers = new int[numbers.Length];

        for (int i = 0; i < k; i++)
        {
            // Взимаме последния елемент
            int lastNumber = numbers[numbers.Length - 1];
            // Копирай numbers от елемент 0 в numbers от елемент 1, копираме целия масив без последния елемент
            Array.Copy(numbers, 0, numbers, 1, numbers.Length - 1);
            // Записваме последния елемент първо
            numbers[0] = lastNumber;


            for (int j = 0; j < numbers.Length; j++)
            {
                rotateNumbers[j] += numbers[j];
            }
        }

        Console.WriteLine(string.Join(" ", rotateNumbers));
    }
}