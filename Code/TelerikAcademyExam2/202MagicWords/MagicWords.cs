using System;
using System.Collections.Generic;
using System.Text;

class MagicWords
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var words = new List<string>();

        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
        }

        // Първа стъпка от алгоритъмът
        for (int i = 0; i < n; i++)
        {
            // Думата, с която се работи е на индекс i
            var word = words[i];
            // Новия индекс по формула len(w0) % (n+1)
            var newIndex = word.Length % (n + 1);

            // Изтриваме старата дума
            // Думата, която трябва да се изтрие я правим на null
            words[i] = null;
            // Вмъкваме думата на новия индекс
            words.Insert(newIndex, word);
            // Премахваме думата null
            words.Remove(null);
        }

        // Втора част на алгоритъмът Print
        // Минава по първата буква на думите и ги долепя, по вторите и т.н.
        var result = new StringBuilder();

        // Първо намираме най-дългата дума, за да знаем до кога да обикаляме по буквите
        var maxLength = 0;
        foreach (var word in words)
        {
            maxLength = Math.Max(maxLength, word.Length);
        }

        // Цикъл по всеки индекс до най-дългата дума
        for (int i = 0; i < maxLength; i++)
        {
            // Цикъл по всяка дума
            foreach (var word in words)
            {
                // Ако дължината на думата е по-голяма от i, за да не даде грешка
                if (word.Length > i)
                {
                    result.Append(word[i]);
                }
            }
        }
        Console.WriteLine(result.ToString());
    }
}