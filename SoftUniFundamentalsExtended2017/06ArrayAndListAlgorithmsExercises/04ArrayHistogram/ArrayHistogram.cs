using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayHistogram
{
    static void Main()
    {
        // Чете подадените думи
        string[] words = Console.ReadLine().Split(' ');

        // Два стринга, единия за думите, другия за броя
        List<string> foundWords = new List<string>();
        List<int> wordCount = new List<int>();

        // Цикъл по дължината на подадените думи
        for (int i = 0; i < words.Length; i++)
        {
            // Променлива за текущата дума
            string currentWord = words[i];

            // Ако намерената дума съдържа текущата дума
            if (foundWords.Contains(currentWord))
            {
                // Увеличи индекса на намерената дума с 1
                int wordIndex = foundWords.IndexOf(currentWord);
                wordCount[wordIndex]++;
            }
            // Ако текущата дума я няма в намерените думи
            else
            {
                // Добави текущата дума към намерените думи
                foundWords.Add(currentWord);
                // Задай, че я има един път
                wordCount.Add(1);
            }
        }

        // Сортиране двата масива едновременно
        bool hasSwapped = true;
        while (hasSwapped)
        {
            hasSwapped = false;
            for (int i = 0; i < wordCount.Count-1; i++)
            {
                if (wordCount[i] < wordCount[i+1])
                {
                    int temp = wordCount[i];
                    wordCount[i] = wordCount[i + 1];
                    wordCount[i + 1] = temp;

                    string tempWord = foundWords[i];
                    foundWords[i] = foundWords[i + 1];
                    foundWords[i + 1] = tempWord;

                    hasSwapped = true;
                }
            }
        }

        // Изход
        for (int i = 0; i < foundWords.Count; i++)
        {
            // Изчисляване на %
            double currentPerventage = (wordCount[i] * 100.0) / words.Length;

            Console.WriteLine("{0} -> {1} times ({2:F2}%)", foundWords[i], wordCount[i], currentPerventage);
        }
    }
}