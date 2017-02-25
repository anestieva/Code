using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Input                           Output
//  1 2 3 4 5 6 7 8 9 10            11	1 10 9 8 7 6 5 4 3 2 11

class FlipListSides
{
    static void Main()
    {
        // Променлива, която чете входа
        List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        // Променлива, която запазва резултата
        List<int> result = new List<int>();

        // Променлива, която запазва дължината на листа
        int countOfNumbers = numbers.Count;

        // Ако листа съдържа четен брой числа
        if (countOfNumbers % 2 == 0)
        {
            // Променлива, която запазва първия елемент
            int firstElement = numbers.First();
            // Променлива, която запазва последния елемент
            int lastElement = numbers.Last();

            // Променлива, в която записваме от числата, махаме първата половина
            // и взимаме втората половина без последното                                            1 2 3 4 5 6
            var firstPartNumbers = numbers.Skip(countOfNumbers / 2).Take(countOfNumbers / 2 - 1);   //  4 5
            // Променлива, в която записваме числата, като махаме първото и взимаме първата половина
            var secondPartNumbers = numbers.Skip(1).Take(countOfNumbers / 2 - 1);                   //  2 3

            // Обръщаме числата
            firstPartNumbers = firstPartNumbers.Reverse();
            secondPartNumbers = secondPartNumbers.Reverse();

            // Добавяме в резултата
            result.Add(firstElement);
            result.AddRange(firstPartNumbers);
            result.AddRange(secondPartNumbers);
            result.Add(lastElement);

            // Принтираме резултата
            Console.WriteLine(String.Join(" ", result));
        }

        // Ако броя на числата е нечетен
        else
        {
            // Променлива, в която запазваме първото число
            int firstElement = numbers.First();
            // Променлива, в която запазваме последното число
            int lastElement = numbers.Last();
            // Променлива, в която запазваме средното число
            int middleElement = numbers[countOfNumbers / 2];

            // Променлива, в която махаме първата половина + средата и взимаме втората половина без последното    1 2 3 4 5 6 7
            var firstPartNumbers = numbers.Skip(countOfNumbers / 2 + 1).Take(countOfNumbers / 2 - 1);             //    5 6
            // Променлива, в която махаме първото число и взимаме първата половина без средата
            var secondPartNumbers = numbers.Skip(1).Take(countOfNumbers / 2 - 1);                                 //    2 3

            // Обръщаме числата
            firstPartNumbers = firstPartNumbers.Reverse();
            secondPartNumbers = secondPartNumbers.Reverse();

            // Добавяме числата в резултата
            result.Add(firstElement);
            result.AddRange(firstPartNumbers);
            result.Add(middleElement);
            result.AddRange(secondPartNumbers);
            result.Add(lastElement);

            // Принтираме резултата
            Console.WriteLine(String.Join(" ", result));
        }
    }
}