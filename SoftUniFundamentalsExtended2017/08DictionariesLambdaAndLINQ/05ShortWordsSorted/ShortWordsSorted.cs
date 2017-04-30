using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ShortWordsSorted
{
    static void Main()
    {
        string[] word = Console.ReadLine()
            // Направи в малки букви
            .ToLower()
            // Сплитни по символите и махни празните места
            .Split(new char[] { ' ', '.', '!', '?', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', }, StringSplitOptions.RemoveEmptyEntries)
           // За всяка думичка, която има дължина по-малко от 5
           .Where(x => x.Length < 5)
            // Сортирай думите
            .OrderBy(w => w)
            // Изчиства тези елементи, които са еднакви
            .Distinct()
            // Направи в масив
            .ToArray();

        Console.WriteLine(string.Join(", ", word));

    }
}