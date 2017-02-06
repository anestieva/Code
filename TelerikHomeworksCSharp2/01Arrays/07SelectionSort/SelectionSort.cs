using System;

// Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, 
// move it at the second position, etc.

class SelectionSort
{
    static void Main()
    {
        // Определяме дължината на масива
        int input = int.Parse(Console.ReadLine());
        // Създаваме масив
        int[] arr = new int[input];
        for (int index = 0; index < input; index++)
        {
            arr[index] = int.Parse(Console.ReadLine());
        }

        int min = int.MaxValue;
        int minIndex = 0;
        int temp = 0;

        for (int i = 0; i < input; i++)
        {
            for (int j = i; j < input; j++)
            {
                if (arr[j] < min)
                {
                    min = arr[j];
                    minIndex = j;
                }
            }
            temp = arr[i];
            arr[i] = min;
            arr[minIndex] = temp;
            min = int.MaxValue;
        }

        for (int index = 0; index < input; index++)
        {
            Console.WriteLine("{0}", arr[index]);
        }
    }
}