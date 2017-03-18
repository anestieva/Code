using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortArrayOfStrings
{
    static void Main()
    {
        List<string> text = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        bool hasSwapped = true;
        while (hasSwapped)
        {
            hasSwapped = false;
            for (int i = 0; i < text.Count - 1; i++)
            {
                int compareResult = String.Compare(text[i], text[i + 1]);
                if (compareResult > 0)
                {
                    string tempWord = text[i];
                    text[i] = text[i + 1];
                    text[i + 1] = tempWord;

                    hasSwapped = true;
                }
            }
        }
        Console.WriteLine(String.Join(" ", text));
    }
}