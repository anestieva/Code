using System;

class VolleyBall
{
    static void Main()
    {
        string year = Console.ReadLine();
        double hodiday = double.Parse(Console.ReadLine());
        double homeWeekends = double.Parse(Console.ReadLine());

        double weekendOfOneYear = 48;
        double weekendInSofia = (weekendOfOneYear - homeWeekends) * 3 / 4;
        double hodidayInSofia = hodiday * 2 / 3;

        double allGame = weekendInSofia + hodidayInSofia + homeWeekends;

        if (year == "leap")
        {
            allGame += allGame * 0.15;
            Console.WriteLine(Math.Floor(allGame));
        }
        else if (year == "normal")
        {
            Console.WriteLine(Math.Floor(allGame));
        }
    }
}