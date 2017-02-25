using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RemoveElementsAtOddPositions
{
    static void Main()
    {
        // Чете входа
        string[] text = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        // Запазва резултаа
        List<string> result = new List<string>();

        // Цикъл по нечетните думи
        for (int i = 1; i < text.Length; i += 2)
        {
            // Добави в резултата нечетните думи
            result.Add(text[i]);
        }

        // Принтирай резултата
        Console.WriteLine(String.Join("", result));
    }
}