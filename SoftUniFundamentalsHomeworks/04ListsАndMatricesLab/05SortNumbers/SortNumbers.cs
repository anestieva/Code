using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Input	            Output
//  8 2 7 3	            2 <= 3 <= 7 <= 8

class SortNumbers
{
    static void Main()
    {
        List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

        numbers.Sort();

        Console.WriteLine(string.Join(" <= ", numbers));
    }
}