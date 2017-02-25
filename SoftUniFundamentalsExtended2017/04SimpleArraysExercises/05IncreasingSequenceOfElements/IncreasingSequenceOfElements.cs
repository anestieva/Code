using System;
using System.Linq;

//  Read an array of integers and find out if it is an increasing sequence. Print Yes if it does and No if it doesn’t.

class IncreasingSequenceOfElements
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        bool increasingSequence = true;

        for (int i = 0; i < array.Length - 1; i++)
        {
            int firstElement = array[i];
            int secondElement = array[i + 1];

            if (firstElement > secondElement)
            {
                increasingSequence = false;
            }
        }

        if (!increasingSequence)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }


    }
}