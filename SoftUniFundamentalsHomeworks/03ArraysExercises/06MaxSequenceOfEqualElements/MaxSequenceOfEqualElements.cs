using System;
using System.Linq;

// Напишете програма, която намира максимална редица от последова¬телни еднакви елементи в масив. 
//
//  Вход                                    Изход
//  2, 1, 1, 2, 3, 3, 2, 2, 2, 1            2, 2, 2


class MaxSequenceOfEqualElements
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Array.Sort(numbers);

        int bestLen = 0;

        int resultNumber = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentLen = 0;

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    currentLen++;
                }
            }
            if (currentLen > bestLen)
            {
                bestLen = currentLen;
                resultNumber = numbers[i];
            }
        }

        for (int i = 0; i < bestLen; i++)
        {
            Console.Write("{0} ",resultNumber);
        }
        Console.WriteLine();
    }
}