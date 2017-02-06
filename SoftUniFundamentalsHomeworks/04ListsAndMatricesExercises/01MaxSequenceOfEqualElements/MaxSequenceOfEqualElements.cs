using System;
using System.Collections.Generic;
using System.Linq;

//  Input                   Output
//  3 4 4 5 5 5 2 2	        5 5 5


class MaxSequenceOfEqualElements
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        int bestLength = 0;
        int bestNum = numbers[0];

        // Цикъл по всички числа
        for (int i = 0; i < numbers.Count; i++)
        {
            // Променлива, която ще записва колко е броя на текущите повтарящи се числа
            int counter = 1;
            // Променлива, чрез която ще се придвижваме по масива
            int j = i + 1;

            // Докато текущото число е по-малко от дължината на масива
            while (j < numbers.Count)
            {
                // Ако символите са еднакви
                if (numbers[i] == numbers[j])
                {
                    // Увеличаваме текущия брой повтарящи се числа
                    counter++;
                }

                // Ако текущия брой е по-голям от максималния намерен до момента
                if (counter > bestLength)
                {
                    // Максималния е равен на текущия
                    bestLength = counter;
                    // Записваме, кое е числото, което се повтаря най-много пъти до момента
                    bestNum = numbers[i];
                }
                // Увеличаваме индекса за да продължим да се движим по масива
                j++;
            }
        }

        for (int i = 0; i < bestLength; i++)
        {
            Console.Write("{0} ", bestNum);
        }
        Console.WriteLine();
    }
}