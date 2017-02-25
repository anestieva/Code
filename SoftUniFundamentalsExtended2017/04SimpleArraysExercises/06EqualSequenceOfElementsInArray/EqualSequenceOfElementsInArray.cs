using System;
using System.Linq;

//  Read an array of integers and find out if all the elements in the array are the same.

class EqualSequenceOfElementsInArray
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        bool equal = true;

        for (int i = 0; i < array.Length - 1; i++)
        {
            int firstElement = array[i];
            int secondElement = array[i + 1];

            if (firstElement != secondElement)
            {
                equal = false;
            }
        }

        if (equal)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}