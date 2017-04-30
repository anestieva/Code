using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddOccurrences
{
    static void Main()
    {
        string[] numbersAsString = Console.ReadLine().ToLower().Split();

        Dictionary<string, int> wordByCount = new Dictionary<string, int>();

        for (int i = 0; i < numbersAsString.Length; i++)
        {
            if (wordByCount.ContainsKey(numbersAsString[i]))
            {
                wordByCount[numbersAsString[i]]++;
            }
            else
            {
                wordByCount[numbersAsString[i]] = 1;
            }
        }

        List<string> words = new List<string>();

        foreach (var word in wordByCount.Keys)
        {
            if (wordByCount[word] % 2 == 1)
            {
                words.Add(word);
            }
        }

        Console.WriteLine(string.Join(", ", words));
    }
}
