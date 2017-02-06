using System;

class ConvertSpeedUnits
{
    static void Main()
    {
        float distanceInMeters = float.Parse(Console.ReadLine());
        float hours = float.Parse(Console.ReadLine());
        float minutes = float.Parse(Console.ReadLine());
        float seconds = float.Parse(Console.ReadLine());

        float inSecond = (hours * 60f * 60f) + (minutes * 60f) + seconds;
        float inHours = hours + (minutes / 60f) + (seconds/60f/60f);
        float distanceInKilometers = distanceInMeters / 1000f;
        float distanceInMiles = distanceInMeters / 1609f;

        Console.WriteLine(distanceInMeters/inSecond);
        Console.WriteLine(distanceInKilometers/inHours);
        Console.WriteLine(distanceInMiles/inHours);
    }
}