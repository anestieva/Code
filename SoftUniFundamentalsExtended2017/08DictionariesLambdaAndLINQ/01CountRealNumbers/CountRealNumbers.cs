using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountRealNumbers
{
    static void Main()
    {
        // Чете числата, като масив от стринг и ги сплитва
        string[] numbersAsString = Console.ReadLine().Split();

        // Създаваме нов масив от дабъл
        double[] numbers = new double[numbersAsString.Length];

        // Цикъл, в който парсваме числата
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(numbersAsString[i]);
        }

        // Сортиран речник
        SortedDictionary<double, int> dic = new SortedDictionary<double, int>();

        // Цикъл по всички числа
        for (int i = 0; i < numbers.Length; i++)
        {
            // Ако речника вече съдържа числото
            if (dic.ContainsKey(numbers[i]))
            {
                // Увеличи броя му с едно
                dic[numbers[i]]++;

            }
            // Ако не съдържа числото
            else
            {
                // Задай му стойност 1
                dic[numbers[i]] = 1;
            }
        }

        // Принтирай речника
        foreach (var num in dic)
        {
            Console.WriteLine("{0} -> {1} times", num.Key, num.Value);
        }

    }
}