using System;

//  Вход                Изход   
//  May                 Apartment: 877.50 lv.
//  15                  Studio: 525.00 lv.
//  
//  Обяснения
//  През май, при повече от 14 нощувки, намаляваме цената на студиото с 30% (50 – 15 = 35), а на апартамента – с 10% (65 – 6.5 =58.5).
//  Целият престой в апартамент – 877.50 лв.
//  Целият престой в студио – 525.00 лв.


class HotelRoom
{
    static void Main()
    {
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());

        double studioPrise = 0;
        double apartamentPrise = 0;

        double apartament = 0;
        double studio = 0;

        switch (month)
        {
            case "May": studioPrise = 50; apartamentPrise = 65; break;
            case "June": studioPrise = 75.20; apartamentPrise = 68.70; break;
            case "July": studioPrise = 76; apartamentPrise = 77; break;
            case "August": studioPrise = 76; apartamentPrise = 77; break;
            case "September": studioPrise = 75.20; apartamentPrise = 68.70; break;
            case "October": studioPrise = 50; apartamentPrise = 65; break;
        }

        if (nights <= 7)
        {
            apartament = nights * apartamentPrise;
            studio = nights * studioPrise;
        }
        else if (nights <= 14 && nights > 7)
        {
            apartament = nights * apartamentPrise;
            studio = nights * studioPrise;
            if (month == "May" || month == "October")
            {
                studio = (nights * studioPrise) * 0.95;
            }
        }
        else if (nights > 14)
        {
            apartament = (nights * apartamentPrise) * 0.90;
            studio = nights * studioPrise;
            if (month == "May" || month == "October")
            {
                studio = (nights * studioPrise) * 0.70;
            }
            if (month == "June" || month == "September")
            {
                studio = (nights * studioPrise) * 0.80;
            }
        }

        Console.WriteLine("Apartment: {0:F2} lv.", apartament);
        Console.WriteLine("Studio: {0:F2} lv.", studio);
    }
}