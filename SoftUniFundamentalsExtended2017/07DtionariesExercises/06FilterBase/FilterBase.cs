using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FilterBase
{
    static void Main()
    {
        // Чете входа
        string input = Console.ReadLine();

        // Декларираме три речника
        Dictionary<string, int> ageResult = new Dictionary<string, int>();
        Dictionary<string, decimal> salaryResult = new Dictionary<string, decimal>();
        Dictionary<string, string> positionResult = new Dictionary<string, string>();

        // Докато входа не е равен на filter base
        while (input != "filter base")
        {
            // Сплитваме входа
            string[] token = input.Split();
            // Променлива за първия елемент
            var first = token[0];
            // Променлива за втория елемент
            var second = token[token.Length - 1];

            // Променливи, в който ще пазим стойностите, ако успеем да ги парснем
            int parsedAge;
            decimal parsedSal;

            // Ако успееш да парснеш към int втория елемент
            if (int.TryParse(second, out parsedAge))
            {
                // Към речника ageResult, добави текущия първи елемент и парснатия втори елемент
                ageResult.Add(first, parsedAge);
            }
            // Ако успееш да парснеш към decimal втория елемент
            else if (decimal.TryParse(second, out parsedSal))
            {
                // Към речника salaryResult, добави текущия първи елемент и парснатия втори елемент
                salaryResult.Add(first, parsedSal);
            }
            // Ако втория елемент е string
            else
            {
                // Добави към третия речник (positionResult), текущите първи и втори елементи 
                positionResult.Add(first, second);
            }
            // Чете входа
            input = Console.ReadLine();
        }

        // Чете входа
        input = Console.ReadLine();

        // Ако входа е "Age"
        if (input == "Age")
        {
            // Принтирай речника age result
            foreach (var kvp in ageResult)
            {
                var userKey = kvp.Key;
                var userValue = kvp.Value;
                Console.WriteLine("Name: {0}", userKey);
                Console.WriteLine("Age: {0}", userValue);
                Console.WriteLine("====================");
            }
        }
        // Ако входа е Salary
        else if (input == "Salary")
        {
            // Принтриай речника salaryResult
            foreach (var kvp in salaryResult)
            {
                var userKey = kvp.Key;
                var userValue = kvp.Value;
                Console.WriteLine("Name: {0}", userKey);
                Console.WriteLine("Salary: {0:f2}", userValue);
                Console.WriteLine("====================");
            }
        }
        // Ако входа е Position
        else
        {
            // Принтирай речника positionResult
            foreach (var kvp in positionResult)
            {
                var userKey = kvp.Key;
                var userValue = kvp.Value;
                Console.WriteLine("Name: {0}", userKey);
                Console.WriteLine("Position: {0}", userValue);
                Console.WriteLine("====================");
            }
        }
    }
}