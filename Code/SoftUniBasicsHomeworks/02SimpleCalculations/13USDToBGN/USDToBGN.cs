using System;

class USDToBGN
{
    static void Main()
    {
        double USD = double.Parse(Console.ReadLine());

        double BGN = USD * 1.79549;

        Console.WriteLine(Math.Round(BGN,2));
    }
}