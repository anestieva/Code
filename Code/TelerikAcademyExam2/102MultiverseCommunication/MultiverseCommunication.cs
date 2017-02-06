using System;
using System.Numerics;

class MultiverseCommunication
{
    const int NumeralSystemBase = 13;

    static int ConvertInputToInt(string currentDigit)
    {
        switch (currentDigit)
        {
            case "CHU": return 0; break;
            case "TEL": return 1; break;
            case "OFT": return 2; break;
            case "IVA": return 3; break;
            case "EMY": return 4; break;
            case "VNB": return 5; break;
            case "POQ": return 6; break;
            case "ERI": return 7; break;
            case "CAD": return 8; break;
            case "K-A": return 9; break;
            case "IIA": return 10; break;
            case "YLO": return 11; break;
            case "PLA": return 12; break;     
            default: throw new ArgumentException();
        }
    }

    static long Power(int power)
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

        int position = input.Length / 3 - 1;
        long result = 0;

        for (int i = 0; i < input.Length; i += 3)
        {
            // Текущия символ е равен на 4 символа
            string currentDigit = input.Substring(i, 3);

            result += ConvertInputToInt(currentDigit) * Power(position);

            position--;

        }
        Console.WriteLine(result);
    }
}