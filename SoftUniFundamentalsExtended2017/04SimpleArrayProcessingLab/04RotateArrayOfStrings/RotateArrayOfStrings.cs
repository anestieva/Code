using System;
using System.Linq;

//  Write a program to read an array of strings, rotate it to the right and print its rotated elements.

class RotateArrayOfStrings
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        string[] rotateArray = new string[array.Length];

        string last = array[array.Length - 1];

        for (int i = 0; i < array.Length - 1; i++)
        {
            rotateArray[i + 1] = array[i];
        }
        rotateArray[0] = last;

        Console.WriteLine(String.Join(" ", rotateArray));
    }
}