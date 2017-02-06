using System;

class SpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1111; i < 10000; i++)
        {
            int number = i;
            int fourthDigit = number % 10;
            number = number / 10;
            int thirdDigit = number % 10;
            number = number / 10;
            int secondDigit = number % 10;
            number = number / 10;
            int firstDigit = number % 10;

            if (firstDigit != 0 && secondDigit != 0 && thirdDigit != 0 && fourthDigit != 0)
            {
                if (n % firstDigit == 0 && n % secondDigit == 0 && n % thirdDigit == 0 && n % fourthDigit == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        Console.WriteLine();
    }
}