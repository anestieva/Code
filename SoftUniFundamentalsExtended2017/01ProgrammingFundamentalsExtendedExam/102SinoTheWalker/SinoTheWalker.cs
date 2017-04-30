using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class SinoTheWalker
{
    static void Main()
    {
        // Променлива, която чете текущия час (Consrole.Readline, формат на времето, култура)
        TimeSpan time = TimeSpan.ParseExact(Console.ReadLine(), @"hh\:mm\:ss", CultureInfo.InvariantCulture);
        // Променлива за стъпките
        decimal numberOfSteps = decimal.Parse(Console.ReadLine());
        // Променлива за времето
        decimal secondsForEachStep = decimal.Parse(Console.ReadLine());

        // Променлива, в която запазваме колко секунди има в един ден
        long secondsInOneDay = 60 * 60 * 24;
        // Променлив, в която умножаваме стъпките по времето и делим на секундите за един ден за да не превърта
        int secondsNeeded = (int)(numberOfSteps * secondsForEachStep % secondsInOneDay);

        // Добавяме секундите
        var result = time.Add(new TimeSpan(0,0,secondsNeeded));

        // Принтираме резултата
        Console.WriteLine("Time Arrival: " + result.ToString(@"hh\:mm\:ss"));
    }
}