using System;

//  Вход            Изход
//  650             Good harvest this year! Total wine: 208 liters.
//  2               33 liters left -> 11 liters per person.
//  175
//  3	
//
//  Обяснение:
//  Общо грозде: 650 * 2 = 1 300 
//  Вино = 40 % *1300 / 2,5 = 208
//  208 > 175
//  208 - 175 = 33 л остават -> 11 л на човек


class Harvest
{
    static void Main()
    {
        double harvest = double.Parse(Console.ReadLine());
        double grapes = double.Parse(Console.ReadLine());
        double wantedWine = double.Parse(Console.ReadLine());
        double workers = double.Parse(Console.ReadLine());

        double allGrapes = (harvest * grapes) / 2.5;
        double wine = allGrapes - (allGrapes * 60 / 100);


        if (wine >= wantedWine)
        {
            if (workers == 0)
            {
                Console.WriteLine("error");
            }
            double littersLeft = Math.Ceiling(wine - wantedWine);
            double litersPerPerson = Math.Ceiling(littersLeft / workers);
            Console.WriteLine("Good harvest this year! Total wine: {0} liters.", wine);
            Console.WriteLine("{0} liters left -> {1} liters per person.", littersLeft, litersPerPerson);

        }
        if (wine < wantedWine)
        {
            double littersNeeded = Math.Floor(wantedWine - wine);
            Console.WriteLine("It will be a tough winter! More {0:F0} liters wine needed.", littersNeeded);
        }
    }
}