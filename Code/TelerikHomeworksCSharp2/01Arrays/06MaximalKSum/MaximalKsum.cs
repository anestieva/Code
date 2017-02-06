using System;

// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.


class MaximalKSum
{
    static void Main()
    {
        // Определяме дължината на масива
        int numberOfElements = int.Parse(Console.ReadLine());
        // Определяме броя на числата, които сумираме
        int sumElements = int.Parse(Console.ReadLine());
        int total = 0;

        // Създаваме масив
        int[] arrayOfNumbers = new int[numberOfElements];

        // Рандом
        Random rng = new Random(); 
        for (int i = 0; i <= numberOfElements - 1; i++)
        {
            arrayOfNumbers[i] = rng.Next(-100, 200);
            Console.Write(arrayOfNumbers[i] + " ");
        }
        Console.WriteLine();

        // Сортираме и обръщаме масива, за да са първи най-големите стойности
        Array.Sort(arrayOfNumbers);
        Array.Reverse(arrayOfNumbers);

        // Нов масив, който ще принтира числата
        int[] output = new int[sumElements];
        for (int i = 0; i <= sumElements - 1; i++)
        {
            output[i] = arrayOfNumbers[i];
            Console.WriteLine(output[i] + " ");
            total += output[i];
        }
        Console.WriteLine(total);
    }
}