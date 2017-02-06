using System;
using System.Linq;

// Напишете програма, която намира най-често повтарящото се число.
//
// Вход                             Изход           Обяснение
// 4 1 1 4 2 3 4 4 1 2 4 9 3	    4	            The number 4 is the most frequent (occurs 5 times)

class MostFrequentNumber
{
    static void Main()
    {
        // Чете входа
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        // Променлива, в която ще записваме максималния брой еднакви числа
        int maxFrequentNumber = 0;
        // Променлива, в която ще записваме кое е числото, което се повтаря максимален брой пъти
        int index = 0;

        // Цикъл по всички числа
        for (int i = 0; i < numbers.Length; i++)
        {
            // Променлива, която ще записва колко е броя на текущите повтарящи се числа
            int counter = 1;
            // Променлива, чрез която ще се придвижваме по масива
            int j = i + 1;

            // Докато текущото число е по-малко от дължината на масива
            while (j < numbers.Length)
            {
                // Ако символите са еднакви
                if (numbers[i] == numbers[j])
                {
                    // Увеличаваме текущия брой повтарящи се числа
                    counter++;
                }

                // Ако текущия брой е по-голям от максималния намерен до момента
                if (counter > maxFrequentNumber)
                {
                    // Максималния е равен на текущия
                    maxFrequentNumber = counter;
                    // Записваме, кое е числото, което се повтаря най-много пъти до момента
                    index = numbers[i];
                }
                // Увеличаваме индекса за да продължим да се движим по масива
                j++;
            }
        }

        // Принтираме кое число се повтаря най-много пъти и колко пъти се повтаря
        Console.WriteLine("Number {0} is {1} times",index, maxFrequentNumber);
    }
}