using System;

//  вход                    изход
//  50                      Somewhere in Bulgaria
//  summer                  Camp - 15.00

class Trip
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        string place = "";
        string destination = "";
        double percent = 0;

        if (money <= 100)
        {
            switch (season)
            {
                case "summer": place = "Camp"; destination = "Bulgaria"; percent = 0.30; break;
                case "winter": place = "Hotel"; destination = "Bulgaria"; percent = 0.70; break;
            }
        }
        else if (money > 100 && money <= 1000)
        {
            switch (season)
            {
                case "summer": place = "Camp"; destination = "Balkans"; percent = 0.40; break;
                case "winter": place = "Hotel"; destination = "Balkans"; percent = 0.80; break;
            }
        }
        else
        {
            switch (season)
            {
                case "summer": place = "Hotel"; destination = "Europe"; percent = 0.90; break;
                case "winter": place = "Hotel"; destination = "Europe"; percent = 0.90; break;
            }
        }

        double result = money * percent;

        Console.WriteLine("Somewhere in {0}", destination);
        Console.WriteLine("{0} - {1:F2}", place, result);
    }
}