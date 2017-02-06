using System;

class FruitShop
{
    static void Main()
    {
        string frut = Console.ReadLine();
        string day = Console.ReadLine();
        double count = double.Parse(Console.ReadLine());

        double price = 0;

        if (day == "Saturday" || day == "Sunday")
        {
            switch (frut)
            {
                case "banana": price = 2.7 * count; break;
                case "apple": price = 1.25 * count; break;
                case "orange": price = 0.90 * count; break;
                case "grapefruit": price = 1.60 * count; break;
                case "kiwi": price = 3.00 * count; break;
                case "pineapple": price = 5.60 * count; break;
                case "grapes": price = 4.20 * count; break;
                default: Console.WriteLine("Error!"); break;
            }
            Console.WriteLine("{0:f2}", price);
        }
        if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
        {
            switch (frut)
            {
                case "banana": price = 2.50 * count; break;
                case "apple": price = 1.20 * count; break;
                case "orange": price = 0.85 * count; break;
                case "grapefruit": price = 1.45 * count; break;
                case "kiwi": price = 2.70 * count; break;
                case "pineapple": price = 5.50 * count; break;
                case "grapes": price = 3.85 * count; break;
                default: Console.WriteLine("Error!"); break;
            }
            Console.WriteLine("{0:f2}", price);

        }
        else
        {
            Console.WriteLine("error");
        }
    }
}