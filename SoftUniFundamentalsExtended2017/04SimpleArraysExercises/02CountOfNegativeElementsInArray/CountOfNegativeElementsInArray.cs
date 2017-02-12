using System;

//  Read an integer N and on the next N lines read an array of integers.Then, find the count of negative elements in the array.

class CountOfNegativeElementsInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int negativeElements = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                negativeElements++;
            }
        }
        Console.WriteLine(negativeElements);
    }
}