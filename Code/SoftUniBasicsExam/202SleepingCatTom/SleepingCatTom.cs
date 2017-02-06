using System;

//  вход                    изход   коментари
//  20	                    Tom sleeps well
//                          95 hours and 25 minutes less for play 
//
//  Обяснение:
//  Почични дни: 20 * 127 = 2 540 минути игра
//  Работни дни: 365 - 20 = 345 * 63 = 21 735 минути игра
//  30 000 > 24 274 => остават 5725 мин = 95 часа и 25 мин


class SleepingCatTom
{
    static void Main()
    {
        int holiday = int.Parse(Console.ReadLine());

        double playTime = (holiday * 127) + ((365 - holiday) * 63);
        double hoursTime = Math.Ceiling(30000 - playTime);

        // намираме колко години и месеци са необходими
        int hoursNeeded = (int)hoursTime / 60;
        int minutesNeeded = (int)hoursTime % 60;

        if (30000 >= playTime)
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine("{0} hours and {1} minutes less for play", hoursNeeded, minutesNeeded);
        }

        if (30000 < playTime)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine("{0} hours and {1} minutes more for play", Math.Abs(hoursNeeded), Math.Abs(minutesNeeded));
        }
    }
}