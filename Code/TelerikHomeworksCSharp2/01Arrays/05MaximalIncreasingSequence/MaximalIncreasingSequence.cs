using System;

// Write a program that finds the maximal increasing sequence in an array.
// Example:
// input                        result
// 3, 2, 3, 4, 2, 2, 4 	        2, 3, 4

class MaximalIncreasingSequence
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputElements = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] inputNum = new int[inputElements.Length];

        for (int i = 0; i < inputElements.Length; i++)
        {
            inputNum[i] = int.Parse(inputElements[i]);
        }

        int number = 0;
        int count = 1;
        int bestCount = 0;

        // Цикъл, с който обхождаме масива
        for (int i = 0; i < inputNum.Length - 1; i++)
        {
            count = 1;
            // Създаваме две променливи, които ще определят символа на масива, като едната е с 1 повече
            int j = i + 1;
            int k = i;
            // Докато първия символ + 1 е равен на следващия символ
            while (inputNum[k] + 1 == inputNum[j])
            {
                // Увеличаваме брояча
                count++;
                j++;
                k++;
                // Проверка, за да не излезнем от масива
                if (j >= inputNum.Length)
                {
                    break;
                }
            }
            // Ако текущия брояч е по-голям от най-големия намерен до момента
            if (count > bestCount)
            {
                // Най-големия е равен на текущия
                bestCount = count;
                // Запазваме символа
                number = i;
            }
        }

        // Принтиране
        for (int i = number; i <= number + bestCount - 1; i++)
        {
            Console.Write("{0} ", inputNum[i]);
        }
    }
}