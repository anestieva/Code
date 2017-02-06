using System;
using System.Collections.Generic;
using System.Linq;

class ArrayModifier
{
    static void Main()
    {
        long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        string command = Console.ReadLine().ToLower();

        while (command != "end")
        {
            string[] userInput = command.Split(' ');

            if (userInput[0] == "swap")
            {
                long firstNumber = long.Parse(userInput[1]);
                long secondNumber = long.Parse(userInput[2]);

                long temp = numbers[firstNumber]; // Copy the first position's element
                numbers[firstNumber] = numbers[secondNumber]; // Assign to the second element
                numbers[secondNumber] = temp;
            }


            if (userInput[0] == "multiply")
            {
                long firstNumber = long.Parse(userInput[1]);
                long secondNumber = long.Parse(userInput[2]);

                numbers[firstNumber] = numbers[firstNumber] * numbers[secondNumber];
            }

            if (userInput[0] == "decrease")
            {
                for (long i = 0; i < numbers.Length; i++)
                {
                    numbers[i]--;
                }
            }
            command = Console.ReadLine().ToLower();
        }
        Console.WriteLine(string.Join(", ", numbers));
    }
}

