using System;
using System.Collections.Generic;

class DurankulakNumbers
{
    static void Main()
    {
        // Метод, който създава бройната система
        string[] durankulakDigits = GetDurankulakDigits();

        // Чете входа
        string durankulakNumber = Console.ReadLine();

        // Метод, който преобразува бройната система
        List<uint> decimalRepresentations = GetDecimalRepresentations(durankulakDigits, durankulakNumber);

        ulong decimalNumber = GetDecimalNumber(decimalRepresentations);
        Console.WriteLine(decimalNumber);
    }

    static ulong GetDecimalNumber(List<uint> decimalRepresentations)
    {
        ulong result = 0;

        for (int i = 0; i < decimalRepresentations.Count; i++)
        {
            result += decimalRepresentations[decimalRepresentations.Count-i- 1] * (ulong)Math.Pow(168, i);
        }

        return result;
    }

    static List<uint> GetDecimalRepresentations(string[] durankulakDigits, string durankulakNumber)
    {
        List<uint> decimalRepresentations = new List<uint>();
        char buffer = new char();

        foreach (char symbol in durankulakNumber)
        {
            if (symbol >= 'A' && symbol <= 'Z')
            {
                string durankulakDigit = null;
                uint decimalRepresentation = 0;

                if (buffer != default(char))
                {
                    durankulakDigit = (buffer + symbol).ToString();   
                    buffer = default(char);
                }
                else
                {
                    durankulakDigit = symbol.ToString();

                }
                decimalRepresentation = (uint)Array.IndexOf(durankulakDigits, durankulakDigit);
                decimalRepresentations.Add(decimalRepresentation);
            }
            else
            {
                buffer = symbol;
            }
        }
        return decimalRepresentations;
    }

    // Метод, който обръща от една бройна система в друга
    private static string[] GetDurankulakDigits()
    {
        // Масив, който пази символите
        string[] durankulakDigits = new string[168];

        // Цикъл по целия масив от 168 символа
        for (int i = 0; i < 167; i++)
        {
            // Ако са до 26 ..A, B, C, D
            if (i < 26)
            {
                durankulakDigits[i] = ((char)('A' + i)).ToString();
            }
            // Ако са от 27 до 52 ..аА, аB, aC
            else if (i < 2 * 26)
            {
                durankulakDigits[i] = "a" + durankulakDigits[i - 26];
            }
            // Ако са от 53 до 78 ..bА, bB, bC
            else if (i < 3 * 26)
            {
                durankulakDigits[i] = "b" + durankulakDigits[i - 2 * 26];
            }
            else if (i < 4 * 26)
            {
                durankulakDigits[i] = "c" + durankulakDigits[i - 3 * 26];
            }
            else if (i < 5 * 26)
            {
                durankulakDigits[i] = "d" + durankulakDigits[i - 4 * 26];
            }
            else if (i < 6 * 26)
            {
                durankulakDigits[i] = "e" + durankulakDigits[i - 5 * 26];
            }
            else if (i < 7 * 26)
            {
                durankulakDigits[i] = "f" + durankulakDigits[i - 6 * 26];
            }
        }
        return durankulakDigits;
    }
}