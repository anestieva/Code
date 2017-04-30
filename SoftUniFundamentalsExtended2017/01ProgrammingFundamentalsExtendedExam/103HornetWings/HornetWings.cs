using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  The contestant has chosen to do 2000 wing flaps.
//  He moves 5 meters per 1000 wing flaps.
//  He rests every 200 wing flaps for 5 seconds.
//  The distance is (2000 / 1000) * 5 = 2 * 5 = 10.00 meters.
//  The hornet flaps 100 times for a second, so 2000 / 100 = 20 seconds.
//  But it also rests for 5 seconds every 200 flaps.
//  (2000 / 200) * 5 = 10 * 5 = 50; 20 + 50 = 70 seconds.
//
//  2000
//  5
//  200

class HornetWings
{
    static void Main()
    {
        // Вход
        long wingFlaps = long.Parse(Console.ReadLine());
        double distance = double.Parse(Console.ReadLine());
        long endurance = long.Parse(Console.ReadLine());

        // Алгоритъм
        double metersTraveled = (wingFlaps / 1000) * distance;
        double secondsPassed = ((wingFlaps / endurance) * 5) + (wingFlaps / 100);

        // Резултат
        Console.WriteLine("{0:f2} m.", metersTraveled);
        Console.WriteLine("{0} s.", secondsPassed);
    }
}
