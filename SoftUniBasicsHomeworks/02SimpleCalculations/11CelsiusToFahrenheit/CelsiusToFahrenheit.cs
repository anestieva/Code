using System;

class CelsiusToFahrenheit
{
    static void Main()
    {
        double celsius = double.Parse(Console.ReadLine());

        double celsiusToFahrenheit = celsius * 1.8 + 32;

        Console.WriteLine(Math.Round(celsiusToFahrenheit,2));
    }
}