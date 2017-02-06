using System;
using System.Collections.Generic;
using System.Linq;

//  Input                               Output
//  1 3 5 7 9                           No matches
//  exchange 1                          [5, 7]
//  max odd                             []
//  min even                            [3, 5, 7, 9, 1]
//  first 2 odd
//  last 2 even
//  exchange 3
//  end	2

class ArrayManipulator
{
    static void Main()
    {
        // Чете входа, като числа от лист
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        // Чете командата
        string command = Console.ReadLine().ToLower();

        // Докато командата не е равна на "end"
        while (command != "end")
        {
            // Прави командата в масив
            string[] userInput = command.Split(' ');

            // Ако командата е "exchange"
            if (userInput[0] == "exchange")
            {
                // Взимаме индекса
                int index = int.Parse(userInput[1]);
                // Ако индекса е по-голям или равен на броя числа или е по-малък от 0
                if (index >= numbers.Count || index < 0)
                {
                    // Принтираме "Invalid index"
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    // Създаваме нов лист, в който махаме числата от първия до индекса, който ни трябва
                    List<int> temp = numbers.Skip(index + 1).ToList();
                    // Добавяме махнатите числа
                    temp.AddRange(numbers.Take(index + 1));
                    // Стария лист е равен на новия
                    numbers = temp;
                }
            }

            // Ако командата е "max"
            if (userInput[0] == "max")
            {
                // Ако е четно
                if (userInput[1] == "even")
                {
                    int maxNumber = int.MinValue;
                    int maxIndex = -1;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int currentNumber = numbers[i];

                        if (maxNumber <= currentNumber && currentNumber % 2 == 0)
                        {
                            maxNumber = currentNumber;
                            maxIndex = i;
                        }
                    }
                    Console.WriteLine(maxIndex);
                }

                if (userInput[1] == "odd")
                {
                    int maxNumber = int.MinValue;
                    int maxIndex = -1;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int currentNumber = numbers[i];

                        if (maxNumber <= currentNumber && currentNumber % 2 != 0)
                        {
                            maxNumber = currentNumber;
                            maxIndex = i;
                        }
                    }
                    Console.WriteLine(maxIndex);
                }
            }


            if (userInput[0] == "min")
            {
                if (userInput[1] == "even")
                {
                    int minNumber = int.MaxValue;
                    int minIndex = -1;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int currentNumber = numbers[i];

                        if (minNumber >= currentNumber && currentNumber % 2 == 0)
                        {
                            minNumber = currentNumber;
                            minIndex = i;
                        }
                    }

                    if (minIndex < 0)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minIndex);
                    }
                }

                if (userInput[1] == "odd")
                {
                    int minNumber = int.MaxValue;
                    int minIndex = -1;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int currentNumber = numbers[i];

                        if (minNumber >= currentNumber && currentNumber % 2 != 0)
                        {
                            minNumber = currentNumber;
                            minIndex = i;
                        }
                    }

                    if (minIndex < 0)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minIndex);
                    }
                }
            }

            if (userInput[0] == "first")
            {
                int count = int.Parse(userInput[1]);
                List<int> current = new List<int>();
                string type = userInput[2];
                int remainder = type == "even" ? 0 : 1;

                if (count > numbers.Count)
                {
                    Console.WriteLine("Invalid count");
                }
                else
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == remainder && current.Count() < count)
                        {
                            current.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine($"[{string.Join(", ", current)}]");           
                }
               
            }

            if (userInput[0] == "last")
            {
                int count = int.Parse(userInput[1]);

                if (count > numbers.Count)
                {
                    Console.WriteLine("Invalid count");
                }
                else
                {
                    string type = userInput[2];
                    int remainder = type == "even" ? 0 : 1;

                    List<int> currentTemp = numbers.Where(x => x % 2 == remainder).Reverse().Take(count).Reverse().ToList();
                    Console.WriteLine($"[{string.Join(", ", currentTemp)}]");
                }
            }

            command = Console.ReadLine().ToLower();
        }
        Console.WriteLine($"[{string.Join(", ", numbers)}]");
    }
}