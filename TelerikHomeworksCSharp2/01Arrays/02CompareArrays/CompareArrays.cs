using System;

// Write a program that reads two integer arrays from the console and compares them element by element.

class CompareArrays
{
    static void Main()
    {
        // Инициализиране дължината на масивите
        int lenght = int.Parse(Console.ReadLine());

        // Създаване на масивите
        int[] firstArray = new int[lenght];
        int[] secondArray = new int[lenght];


        // Запълване на масивите
        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        // Създаваме булева, в която пазим истина
        bool equal = true;

        // Сравняване на масивите като обхождаме
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                equal = false;
            }
        }

        if (equal)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}