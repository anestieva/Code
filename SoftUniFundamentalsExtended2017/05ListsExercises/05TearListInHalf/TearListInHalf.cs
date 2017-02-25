using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Input                       Output
//  11 22 33 45 14 12	        4 11 5 1 22 4 1 33 2

class TearListInHalf
{
    static void Main()
    {
        // Чете входа
        List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        // Две променливи за двете половини на листа
        List<int> firstPart = numbers.Take(numbers.Count / 2).ToList();
        List<int> secondPart = numbers.Skip(numbers.Count / 2).ToList();

        // Една променлива за резултата
        List<int> result = new List<int>();

        // Цикъл до първата половина
        for (int i = 0; i < firstPart.Count; i++)
        {
            // Добавяме към резултата числото  
            result.Add(secondPart[i] / 10);  //  45 => 4
            result.Add(firstPart[i]);        //  45 => 45
            result.Add(secondPart[i] % 10);  //  45 => 5
        }
        // Принтираме резултата
        Console.WriteLine(String.Join(" ", result));
    }
}