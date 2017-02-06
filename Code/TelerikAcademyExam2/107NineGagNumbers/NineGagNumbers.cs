using System;

class NineGagNumbers
{
    static string ConvertStringToNumber(string digit)
    {
        string result = "NO";
        switch (digit)
        {
            case "-!": result = "0"; break;
            case "**": result = "1"; break;
            case "!!!": result = "2"; break;
            case "&&": result = "3"; break;
            case "&-": result = "4"; break;
            case "!-": result = "5"; break;
            case "*!!!": result = "6"; break;
            case "&*!": result = "7"; break;
            case "!!**!-": result = "8"; break;
        }
        return result;
    }

    static ulong Power(int power)
    {
        ulong result = 1;

        for (int i = 0; i < power; i++)
        {
            result *= 9;
        }

        return result;
    }

    static void Main()
    {
        string input = Console.ReadLine();
        string nineSystem = string.Empty;

        // Стринг, който пази до къде сме стигнали
        string partialInput = string.Empty;

        // Автомат
        for (int i = 0; i < input.Length; i++)
        {
            partialInput += input[i];

            string currentDigit = ConvertStringToNumber(partialInput);

            if (currentDigit != "NO")
            {
                nineSystem += currentDigit;
                partialInput = "";
            }
        }

        ulong result = 0;

        for (int i = 0; i < nineSystem.Length; i++)
        {
            ulong digit = ulong.Parse(nineSystem[i].ToString());
            result += digit * Power(nineSystem.Length-i-1);
        }

        Console.WriteLine(result);
    }
}