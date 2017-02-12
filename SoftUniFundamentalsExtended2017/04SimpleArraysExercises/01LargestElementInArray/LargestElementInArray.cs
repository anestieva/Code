using System;
using System.Linq;

// Read an integer N and on the next N lines read an array of integers. Then, find its largest element.

class LargestElementInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int largestElement = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            int currentElement = array[i];
            if (currentElement > largestElement)
            {
                largestElement = currentElement;
            }
        }
        Console.WriteLine(largestElement);
    }
}