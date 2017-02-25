using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Input                   Output
//  1 2 3 4 5               Yes. Sum: 15
//  5 3 2 7 4 1 8		
//  
//  first list: 1 2 3 4 5
//  second list: 5 3 2 7 4 1 8
//  elements to remove: 5 3 2 7 4 1 8
//  resulting list: 7 8
//  list1 sum: 1 + 2 + 3 + 4 + 5 = 15
//  list2 sum: 7 + 8 = 15
//  list1 sum == list2 sum  Equal sum

class EqualSumAfterExtraction
{
    static void Main()
    {
        // Чете двата листа от числа
        List<string> firstNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> secondNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        // Променливи, които ще пазят сумата от числата
        int firstSum = 0;
        int secondSum = 0;

        // За всяко число в първия лист
        foreach (var number in firstNumbers)
        {
            // Ако във втория лист се съдържа число от първия лист
            if (secondNumbers.Contains(number))
            {
                // Премахни това число от втория лист
                secondNumbers.Remove(number);
            }
        }

        // Сумирай числата от двата листа
        for (int i = 0; i < firstNumbers.Count; i++)
        {
            firstSum += int.Parse(firstNumbers[i]);
        }
        for (int i = 0; i < secondNumbers.Count; i++)
        {
            secondSum += int.Parse(secondNumbers[i]);
        }

        //  Ако сумата е равна
        if (firstSum == secondSum)
        {
            Console.WriteLine("Yes. Sum: {0}", firstSum);
        }
        // Ако сумата не е равна
        else
        {
            Console.WriteLine("No. Diff: {0}", Math.Abs(firstSum-secondSum));
        }

    }
}