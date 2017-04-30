using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DefaultValues
{
    static void Main()
    {
        // Чете входа
        string input = Console.ReadLine();

        // Декларираме речник
        Dictionary<string, string> result = new Dictionary<string, string>();

        // Докато командата не е end
        while (input != "end")
        {
            // Сплитваме входа
            string[] token = input.Split(new[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Взимаме първия елемент
            string key = token[0];
            // Взимаме втория елемент и го парсваме към дата
            string value = token[1];

            // Добавяме в речника, но ако вече го има го обнови
            result[key] = value;

            input = Console.ReadLine();
        }

        string defaultValue = Console.ReadLine();

        Dictionary<string, string> unchange = result
            .Where(x => x.Value != "null")
            .OrderByDescending(x => x.Value.Length)
            .ToDictionary(x => x.Key, x => x.Value);

        Dictionary<string, string> change = result
            .Where(x => x.Value == "null")
            .ToDictionary(x => x.Key, x => x.Value);


        // Принтиране на речник
        foreach (var entry in unchange)
        {
            // Променлива за ключ
            var key = entry.Key;
            // Променлива за стойност
            var value = entry.Value;

            // Принтиране на резултата
            Console.WriteLine("{0} <-> {1}", key, value);
        }

        // Принтиране на речник
        foreach (var entry in change)
        {
            // Променлива за ключ
            var key = entry.Key;
            // Променлива за стойност
            var value = entry.Value;

            // Принтиране на резултата
            Console.WriteLine("{0} <-> {1}", key, value);
        }
    }
}