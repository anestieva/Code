using System;
using System.Collections.Generic;

class MixedPhones
{
    static void Main()
    {
        // Чете входа
        string input = Console.ReadLine();

        // Декларираме сортиран речник
        SortedDictionary<string, long> result = new SortedDictionary<string, long>();

        // Докато командата не е end
        while (input != "Over")
        {
            // Сплитваме входа
            var token = input.Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Взимаме първия елемент
            var firstElement = token[0];
            // Взимаме последния елемент
            var secondElement = token[1];

            // Променлива за число
            long number = 0;

            // Ако можеш да парснеш първия елемент го запиши в number
            if (long.TryParse(firstElement, out number))
            {
                // В речника за стойност към първи елемент записваме числото
                result[secondElement] = number;
            }
            // Ако не можеш да го парснеш
            else if (long.TryParse(secondElement, out number))
            {
                // В речника за стойност към първи елемент записваме числото
                result[firstElement] = number;
            }
            // Прочети отново входа
            input = Console.ReadLine();
        }

        // Принтиране на речник
        foreach (var number in result)
        {
            // Променлива за ключ
            var name = number.Key;
            // Променлива за стойност
            var phoneNumber = number.Value;

            // Принтиране на резултата
            Console.WriteLine("{0} -> {1}", name, phoneNumber);
        }
    }
}