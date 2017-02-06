using System;

// Write a program that finds the maximal sequence of equal elements in an array.

class MaximalSequence
{
    static void Main()
    {
        // Чете входа
        string input = Console.ReadLine();
        // Сплит
        string[] inputElements = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Създаваме масив от инт
        int[] inputNums = new int[inputElements.Length];

        // Запълваме масив от инг
        for (int i = 0; i < inputElements.Length; i++)
        {
            inputNums[i] = int.Parse(inputElements[i]);
        }

        int currentLength = 1; //Текуща дължина
        int maxLength = 0; // Най-дълго до момента
        int number = 0; // Число в момента

        // Цикъл по дължината
        for (int i = 0; i < inputNums.Length - 1; i++)
        {
            // Ако текущия символ е равен на следващия
            if (inputNums[i] == inputNums[i + 1])
            {
                // Увеличаваме текущата дължина
                currentLength++;
            }
            else
            {
                // Ако текущата дължина е по-голяма от намерената до момента
                if (currentLength > maxLength)
                {
                    // Дължината до момента е равна на текущата
                    maxLength = currentLength;
                    // Запазваме символа, който го има най-много пъти
                    number = inputNums[i];
                }
                // Нулираме текущата дължина
                currentLength = 1;
            }
        }

        // Ако всички символи са еднакви
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            number = inputNums[inputNums.Length - 1];
        }
        Console.WriteLine("The maximal sequence is: number {0} repeated {1} times", number, maxLength);
    }
}