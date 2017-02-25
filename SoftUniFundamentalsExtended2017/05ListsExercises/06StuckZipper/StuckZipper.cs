using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Input                   Output
//  2 4 4 3 9               4 2 1 4 3 4 2 3 7 9
//  4 1 3 2 7	

class StuckZipper
{
    static void Main()
    {
        // Чете два листа
        var firstPart = Console.ReadLine().Split().Select(int.Parse).ToList();
        var secondPart = Console.ReadLine().Split().Select(int.Parse).ToList();

        // Променлива, която намира най-малката дължина на елементите и в двата масива
        var min = Math.Min(firstPart.Min(), secondPart.Min()).ToString().Length;

        // Цикъл, с който премахваме елементите, които са по-големи от намерения минимален
        for (int i = 0; i < firstPart.Count; i++)
        {
            if (firstPart[i].ToString().Length > min)
            {
                firstPart.Remove(firstPart[i]);
                i--;
            }
        }
        // Цикъл, с който премахваме елементите, които са по-големи от намерения минимален
        for (int i = 0; i < secondPart.Count; i++)
        {
            if (secondPart[i].ToString().Length > min)
            {
                secondPart.Remove(secondPart[i]);
                i--;
            }
        }

        // Променлива, в която пазим резултата
        var result = new List<int>();

        // Променлива, с която определяме индекса
        int index = 1;
        // Цикъл по първия лист
        for (int i = 0; i < firstPart.Count; i++)
        {
            // Променлива, която взима текущия елемент
            var currentElement = firstPart[i];
            // Във втория лист вмъкваме на определения индекс текущия елемент, като взимаме по-малкото от индекса или дължината на масва
            secondPart.Insert(Math.Min(index, secondPart.Count), currentElement);
            // Увеличаваме индекса с 2, за да прескачаме един елемент
            index += 2;
        }

        // Принтираме резултата
        Console.WriteLine(string.Join(" ", secondPart));
    }
}