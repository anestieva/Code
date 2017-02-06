using System;

class Time15Minutes
{
    static void Main()
    {
        var hour = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());

        TimeSpan time = new TimeSpan(hour, minutes, 0);
        TimeSpan fifteenMinutes = new TimeSpan(0, 15, 0);
        TimeSpan total = time + fifteenMinutes;

        Console.WriteLine("{0:h\\:mm}", total);
    }
}