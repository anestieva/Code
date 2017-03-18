using System;
using System.Collections.Generic;

class DictRef
{
    static void Main()
    {
        // Чете входа
        string input = Console.ReadLine();

        // Декларираме речник
        Dictionary<string, int> result = new Dictionary<string, int>();

        // Докато командата не е end
        while (input != "end")
        {
            // Сплитваме входа
            string[] token = input.Split();

            // Взимаме първия елемент
            string firstElement = token[0];
            // Взимаме последния елемент
            string lastElement = token[token.Length - 1];

            // Променлива за число
            int number = 0;

            // Ако можеш да парснеш последния елемент го запиши в number
            if (int.TryParse(lastElement, out number))
            {
                // В речника за първи елемент записваме стойността
                result[firstElement] = number;
            }
            // Ако не можеш да го парснеш
            else
            {
                // Ако резултата съдържа последния елемент
                if (result.ContainsKey(lastElement))
                {
                    // Променлива, която взима стойността на последния елемент
                    var referensedValue = result[lastElement];
                    // Запиши в текущия елемент стойността на последния елемент
                    result[firstElement] = referensedValue;
                }

            }
            // Прочети отново входа
            input = Console.ReadLine();
        }

        // Принтиране на речник
        foreach (var itemPricePair in result)
        {
            // Променлива за ключ
            var item = itemPricePair.Key;
            // Променлива за стойност
            var price = itemPricePair.Value;

            // Принтиране на резултата
            Console.WriteLine("{0} === {1}", item, price);
        }

    }
}