using System;
using System.Linq;

//  Write a program to read an array of integers and find how many odd numbers at odd positions the array holds. 
//  If there are no numbers which match this criteria, do not print anything

class OddNumbersAtOddPositions
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] % 2 != 0)
            {
                Console.WriteLine($"Index {i} -> {array[i]}");
            }
        }
    }
}