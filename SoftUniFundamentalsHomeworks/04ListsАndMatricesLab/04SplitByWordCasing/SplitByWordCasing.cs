using System;
using System.Collections.Generic;
using System.Linq;

//  Input                                           
//  Learn programming at SoftUni: Java, PHP, JS, HTML 5, CSS, Web, C#, SQL, databases, AJAX, etc.	
//
//  Output
//  Lower-case: programming, at, databases, etc
//  Mixed-case: Learn, SoftUni, Java, 5, Web, C#
//  Upper-case: PHP, JS, HTML, CSS, SQL, AJAX

class SplitByWordCasing
{
    static void Main()
    {
        List<string> words = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' },
                                                                    StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> lowerCase = new List<string>();
        List<string> mixedCase = new List<string>();
        List<string> upperCase = new List<string>();

        foreach (var word in words)
        {
            int lower = 0;
            int upper = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLower(word[i]))
                {
                    lower++;
                }
                else if (char.IsUpper(word[i]))
                {
                    upper++;
                }
            }

            if (upper == word.Length)
            {
                upperCase.Add(word);
            }
            else if (lower == word.Length)
            {
                lowerCase.Add(word);
            }
            else
            {
                mixedCase.Add(word);
            }
        }

        Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
        Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
        Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
    }
}