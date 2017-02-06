using System;

// Write a program that finds in given array of integers a sequence of given sum S(if present).
// Example:
// array                        S            result
// 4, 3, 1, 4, 2, 5, 8 	        11 	        4, 2, 5

class FindSumInArray
{
    static void Main()
    {
        // Определяне дължината на масива
        int n = int.Parse(Console.ReadLine());

        // Създаване на масив
        int[] arr = new int[n];
        for (int index = 0; index < n; index++)
        {
            arr[index] = int.Parse(Console.ReadLine());
        }

        // Определяне на стойността, която търсим
        int s = int.Parse(Console.ReadLine());

        // Променливи за сума и булева за решение
        int sum = 0;
        bool solution = false;

        // Два вложени цикъла, които да пробват различни комбинации
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                // Съм сумата добавяме текущата стойност
                sum += arr[j];

                // Ако сумата и желаната сума са равни
                if (sum == s)
                {
                    solution = true;
                    Console.Write("The following sequence has the sum of {0}: ", s);
                    for (int print = i; print <= j; print++)
                    {
                        Console.Write("{0} ", arr[print]);
                    }
                    Console.WriteLine();
                }
            }
            sum = 0;
        }
        Console.WriteLine();
        // Ако няма решение
        if (!solution)
        {
            Console.WriteLine("There is no sequnce with the sum of {0}!\n", s);
        }
    }
}