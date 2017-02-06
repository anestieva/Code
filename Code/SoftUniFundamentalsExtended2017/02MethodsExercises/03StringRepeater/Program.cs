using System;

//  Write a RepeatString(str, count) method that receives a string and an integer N as parameters 
//  and returns the string, repeated N times. After that, print the result on the console.

class StringRepeater
{
    static void Main()
    {
        string stringToRepeat = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());

        Console.WriteLine(RepeatSrting(stringToRepeat, count));
    }

    static string RepeatSrting(string str, int count)
    {
        string repeatedString = string.Empty;

        for (int i = 0; i < count; i++)
        {
            repeatedString += str;
        }
        return repeatedString;
    }
}