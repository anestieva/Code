using System;
using System.Linq;

//  Read an array of integers and print how many times a given element exists in it.

class CountOfGivenElementInArray
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int givenElement = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == givenElement)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}