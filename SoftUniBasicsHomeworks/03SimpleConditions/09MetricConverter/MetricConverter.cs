using System;

class MetricConverter
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());
        string firstMetric = Console.ReadLine();
        string secondMetric = Console.ReadLine();

        double baseMetricValue = input;

        switch (firstMetric)
        {
            case "m": baseMetricValue = baseMetricValue / 1; break;
            case "mm": baseMetricValue = baseMetricValue / 1000; break;
            case "cm": baseMetricValue = baseMetricValue / 100; break;
            case "mi": baseMetricValue = baseMetricValue / 0.000621371192; break;
            case "in": baseMetricValue = baseMetricValue / 39.3700787; break;
            case "km": baseMetricValue = baseMetricValue / 0.001; break;
            case "ft": baseMetricValue = baseMetricValue / 3.2808399; break;
            case "yd": baseMetricValue = baseMetricValue / 1.0936133; break;
            default: Console.WriteLine("Error"); break;
        }

        switch (secondMetric)
        {
            case "m": baseMetricValue = baseMetricValue * 1; break;
            case "mm": baseMetricValue = baseMetricValue * 1000; break;
            case "cm": baseMetricValue = baseMetricValue * 100; break;
            case "mi": baseMetricValue = baseMetricValue * 0.000621371192; break;
            case "in": baseMetricValue = baseMetricValue * 39.3700787; break;
            case "km": baseMetricValue = baseMetricValue * 0.001; break;
            case "ft": baseMetricValue = baseMetricValue * 3.2808399; break;
            case "yd": baseMetricValue = baseMetricValue * 1.0936133; break;
            default: Console.WriteLine("Error"); break;
        }

        Console.WriteLine(baseMetricValue);
    }
}