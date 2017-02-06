using System;

// Write a program that finds the most frequent number in an array.
// Example:
// input                                    result
// 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	4 (5 times)

class FrequentNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] elements = input.Split(new char[] {' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        // Попълване на масива
        int[] array = new int[elements.Length];
        for (int i = 0; i < elements.Length - 1; i++)
        {
            array[i] = int.Parse(elements[i]);
        }

        // Сортиране на масива
        Array.Sort(array);

        // Променливи, в които ще пазим числото и броя
        int number = 0;
        int count = 0;
        int bestCount = 0;

        // Цикъл, с който обхождаме масива
        for (int i = 1; i < elements.Length - 1; i++)
        {
            // Ако символа е равен на следващия символ
            if (array[i] == array[i - 1])
            {
                // Увеличаваме броя еднакви, последователни символи
                count++;

                // Ако броя в момента е по-голям от най-големия брой
                if (count > bestCount)
                {
                    // Най-големия брой присвоява стойността на намерения в момента
                    bestCount = count;
                    // Запазваме числото, което се повтаря най-много пъти
                    number = array[i];
                }
            }

            // Ако всички символи са различни
            else
            {
                count = 1;
            }
        }

        // Принтираме
        Console.WriteLine("\nThe maximal sequence is: number {0} repeated {1} times", number, bestCount);
    }
}