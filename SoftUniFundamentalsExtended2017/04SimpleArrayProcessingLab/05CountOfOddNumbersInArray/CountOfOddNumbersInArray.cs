using System;
using System.Linq;
using System.Text;

//  Write a program to read an array of integers and find how many odd elements it holds.

class CountOfOddNumbersInArray
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int oddNumbers = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                oddNumbers++;
            }
        }
        Console.WriteLine(oddNumbers);
    }
}