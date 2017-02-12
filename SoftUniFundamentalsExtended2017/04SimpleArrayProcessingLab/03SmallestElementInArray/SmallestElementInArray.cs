using System;
using System.Linq;

//  Write a program to read an array of integers, find the smallest element and print it.

class SmallestElementInArray
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int minElement = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentElement = numbers[i];

            if (currentElement < minElement)
            {
                minElement = currentElement;
            }
        }

        Console.WriteLine(minElement);
    }
}