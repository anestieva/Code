using System;
using System.Collections.Generic;

class LetterRepetition
{
    static void Main()
    {
        // Чете входа
        string input = Console.ReadLine();

        // Деклариране на речник
        Dictionary<char, int> letterCount = new Dictionary<char, int>();

        // Цикъл по стринга за да вземем всяка буква
        foreach (var letter in input)
        {
            // Ако буквата вече я има в речника
            if (letterCount.ContainsKey(letter))
            {
                // Увеличи броя на текущата буква
                letterCount[letter]++;
            }
            // Ако буквата я няма в речника
            else
            {
                // Добави буквата в речника
                letterCount.Add(letter, 1);
            }
        }

        // Принтиране на речник
        foreach (var letterCountPair in letterCount)
        {
            // Взимаме текучата буква
            var letter = letterCountPair.Key;
            // Взимаме стойността на текущата буква
            var count = letterCountPair.Value;

            // Принтираме резултата
            Console.WriteLine("{0} -> {1}", letter, count);
        }
    }
}