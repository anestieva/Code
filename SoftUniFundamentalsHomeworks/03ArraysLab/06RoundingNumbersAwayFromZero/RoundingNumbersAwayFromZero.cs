using System;
using System.Linq;

class RoundingNumbersAwayFromZero
{
    static void Main()
    {
        double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

        int[] roundingAwayFromZero = new int[numbers.Length];
        int[] roundingToEven = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            roundingAwayFromZero[i] = (int)(Math.Round(numbers[i], MidpointRounding.AwayFromZero));
            roundingToEven[i] = (int)(Math.Round(numbers[i], MidpointRounding.ToEven));
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"{numbers[i]} => {roundingAwayFromZero[i]} => {roundingToEven[i]}");
        }    
    }
}