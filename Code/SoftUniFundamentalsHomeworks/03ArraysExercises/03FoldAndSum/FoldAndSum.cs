using System;
using System.Linq;

// Програма, която събира различни елементи на масива и ги принтира в нов масив
//
// Вход                     Изход                   Обяснение
//  1 2 3 4 5 6 7 8	        5 5 13 13	            2  1  8  7  +
//                                                  3  4  5  6  =
//                                                  5  5 13 13

class FoldAndSum
{
    static void Main()
    {
        // Вход
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        // Намираме к
        int k = numbers.Length / 4;

        // Създаваме три променливи, които ще пазят числата
        int[] middleNumbers = new int[k * 2];
        int[] leftNumbers = new int[k];
        int[] rightNumbers = new int[k];

        // Цикъл, с който записваме средните числа
        for (int i = 0; i < middleNumbers.Length; i++)
        {
            middleNumbers[i] = numbers[i + k];
        }

        // Цикъл, с който записваме левите числа
        for (int i = 0; i < leftNumbers.Length; i++)
        {

            leftNumbers[i] = numbers[i];
        }

        // Цикъл, с който записваме десните числа
        for (int i = 0; i < rightNumbers.Length; i++)
        {
            rightNumbers[i] = numbers[i + k * 3];
        }

        // Обръщаме числата, както е по условие
        Array.Reverse(leftNumbers);
        Array.Reverse(rightNumbers);

        // Създаваме нов масив, в който ще запишем левите и десните числа
        int[] leftAndRightElements = new int[middleNumbers.Length];

        // Цикъл, с който записваме левите и десните числа
        for (int i = 0; i < middleNumbers.Length; i++)
        {
            if (i < k)
            {
                leftAndRightElements[i] = leftNumbers[i];
            }
            else
            {
                leftAndRightElements[i] = rightNumbers[i - k];
            }
        }

        // Цикъл, с който сумираме двата нови масива
        for (int i = 0; i < middleNumbers.Length; i++)
        {
            middleNumbers[i] += leftAndRightElements[i];
        }

        // Принтираме резултатът
        Console.WriteLine(string.Join(" ", middleNumbers));
    }
}