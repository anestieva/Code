using System;
using System.Collections.Generic;

class Zerg
{
    const int NumeralSystemBase = 15;

    static int ConvertInputToInt(string currentDigit)
    {
        switch (currentDigit)
        {
            case "Rawr": return 0; break;
            case "Rrrr": return 1; break;
            case "Hsst": return 2; break;
            case "Ssst": return 3; break;
            case "Grrr": return 4; break;
            case "Rarr": return 5; break;
            case "Mrrr": return 6; break;
            case "Psst": return 7; break;
            case "Uaah": return 8; break;
            case "Uaha": return 9; break;
            case "Zzzz": return 10; break;
            case "Bauu": return 11; break;
            case "Djav": return 12; break;
            case "Myau": return 13; break;
            case "Gruh": return 14; break;
            default: throw new ArgumentException();
        }
    }


    static long Power (int power)
    {
        long result = 1;

        for (int i = 0; i < power; i++)
        {
            result *= NumeralSystemBase;
        }
        return result;
    }

    static void Main()
    {
        string input = Console.ReadLine();

        int position = input.Length / 4-1;
        long result = 0;

        for (int i = 0; i < input.Length; i += 4)
        {
            // Текущия символ е равен на 4 символа
            string currentDigit = input.Substring(i, 4);

            result += ConvertInputToInt(currentDigit) * Power(position);

            position--;

        }
        Console.WriteLine(result);
    }
}