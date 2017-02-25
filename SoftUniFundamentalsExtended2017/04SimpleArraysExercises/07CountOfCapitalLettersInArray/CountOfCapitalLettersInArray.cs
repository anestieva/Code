using System;
using System.Linq;

//  Read an array of strings and find out how many of them are capital English letters(such as A, B, C etc.). Print the count on the console.

class CountOfCapitalLettersInArray
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        int count = 0;

        foreach (var symbol in array)
        {
            if (symbol[0] >= 65 && symbol[0] <= 90 && symbol.Length == 1)
            {
                count++;
            }
        }    
        Console.WriteLine(count);
     }
}