using System;

class Cinema
{
    static void Main()
    {
        string type = Console.ReadLine();
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        double price = 0;

        switch (type)
        {
            case "Premiere": price = row * col * 12; break;
            case "Normal": price = row * col * 7.50; break;
            case "Discount": price = row * col * 5; break;
        }
        Console.WriteLine("{0:f2} leva", price);
    }
}