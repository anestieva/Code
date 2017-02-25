using System;

//  Read an array of strings and find out if it’s symmetric. If it is, print “Yes”, otherwise print “No”.

class ArraySymmetry
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] firstPart = new string[array.Length / 2];
        string[] secondPart = new string[array.Length / 2];
        bool symmetric = true;

        for (int i = 0; i < array.Length / 2; i++)
        {
            firstPart[i] = array[i];
        }

        for (int i = 0; i < array.Length / 2; i++)
        {
            secondPart[i] = array[i + firstPart.Length];
        }

        Array.Reverse(secondPart);

        for (int i = 0; i < firstPart.Length; i++)
        {
            if (firstPart[i] != secondPart[i])
            {
                symmetric = false;
            }
        }

        if (symmetric)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}