using System;
using System.Linq;

//  Input                   Output  
//  10                      Ivancho has enough money - it would cost 4.80lv.For 12 guests – 2 sets of 6 portions
//  12
//  0.35
//  0.20
//  4.50	
//
//  Comments
//  Needed product:
//  2*(2 bananas), 2*(4 eggs), 2*(0.2 kilos berries) 
//  2*(2*0.35) + 2*(4*0.20) + 2*(0.2*4.50) = 4.80
//  4.80 <= 10 – the money will be enough.


class SweetDessert
{
    static void Main()
    {
        double amountOfCash = double.Parse(Console.ReadLine());
        int numberOfGuests = int.Parse(Console.ReadLine());
        double priceOfBananas = double.Parse(Console.ReadLine());
        double priceOfEggs = double.Parse(Console.ReadLine());
        double priceOfBerries = double.Parse(Console.ReadLine());

        // Закръгляне на порциите към по-високо
        int portion = (int)Math.Ceiling((double)numberOfGuests / 6);

        double price = (portion * (2 * priceOfBananas)) + (portion * (4 * priceOfEggs)) + (portion * (0.2 * priceOfBerries));

        if (amountOfCash >= price)
        {
            Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", price);
        }
        else
        {
            Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", price - amountOfCash);
        }
    }
}