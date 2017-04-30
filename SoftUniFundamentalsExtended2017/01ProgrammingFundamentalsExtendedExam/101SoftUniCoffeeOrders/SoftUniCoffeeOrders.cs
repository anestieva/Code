using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//  Input                       Output                                          Comments
//  2                           The price for the coffee is: $464.07            We are given only 1 order. Then we  use the formulas:
//  4.99                        The price for the coffee is: $54.25             orderPrice = 30 (days in June 2016) * 8 * 1.53 = 367.20
//  6/07/2016                   Total: $518.32
//  3
//  0.35
//  03/01/2013
//  5	

class SoftUniCoffeeOrders
{
    static void Main()
    {
        // Променлива за броя дни
        int n = int.Parse(Console.ReadLine());
        // Променлива за резултата
        decimal total = 0m;

        // Цикъл до броя дни
        for (int i = 0; i < n; i++)
        {
            // Променлива за цената на кафето
            decimal coffePrice = decimal.Parse(Console.ReadLine());
            // Променлива за датата (Console.ReadLine(), формат, култура)
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            // Променлива за капсулите
            long capsules = long.Parse(Console.ReadLine());

            // Променлива, която дава колко дни има месеца
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month); // Метод DaysInMonth иска първи параметър година и втори месец

            // Променлива за текущата цена (дните в месеца * капсулите * цената на кафето)
            decimal currentPrice = ((daysInMonth * (long)capsules) * coffePrice);
            // Резултата + текущата цена
            total += currentPrice;

            // Принтираме текущата цена
            Console.WriteLine("The price for the coffee is: ${0:F2}", currentPrice);
        }
        // Принтираме резултата
        Console.WriteLine("Total: ${0:F2}", total);
    }
}