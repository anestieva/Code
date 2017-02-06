using System;

class EqualWords
{
    static void Main()
    {
        string firstWord = Console.ReadLine().ToLower();
        string secondWord = Console.ReadLine().ToLower();

        int result = string.Compare(firstWord, secondWord);

        if (result == 0)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}