using System;
using System.Numerics;

class StrangelandNumbers
{
    // Метод за вдигане на степен вместо Math.Pow
    static BigInteger Power(int number, int power)
    {
        BigInteger result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }
        return result;
    }

    static void Main()
    {
        string input = Console.ReadLine()
            .Replace("a", "0")
            .Replace("b", "1")
            .Replace("c", "2")
            .Replace("d", "3")
            .Replace("e", "4")
            .Replace("f", "5")
            .Replace("g", "6")
            .Replace("h", "7")
            .Replace("i", "8")
            .Replace("j", "9")
            .Replace("k", "10")
            .Replace("l", "11")
            .Replace("m", "12")
            .Replace("n", "13")
            .Replace("o", "14")
            .Replace("p", "15")
            .Replace("q", "16")
            .Replace("r", "17")
            .Replace("s", "18")
            .Replace("t", "19")
            .Replace("u", "20")
            .Replace("v", "21")
            .Replace("w", "22");



        string[] nextInput = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);


        int power = 0;
        BigInteger result = 0;

        // Алгоритъм за конвентиране от определена бройна система в десетична
        for (int i = nextInput.Length - 1; i >= 0; i--)
        {
            // Променлива, която от стринга превръща в число
            BigInteger currentNumber = input[i];
            result += currentNumber * Power(23, power);
            power++;
        }
        Console.WriteLine(result);

    }
}