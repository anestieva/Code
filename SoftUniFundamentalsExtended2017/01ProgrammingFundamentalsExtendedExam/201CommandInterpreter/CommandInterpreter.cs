using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Input                               Output
//  1 2 5 8 7 3 10 6 4 9                [1, 2, 3, 7, 8, 5, 10, 6, 4, 9]
//  reverse from 2 count 4
//  end
//
//	"reverse from [start] count [count]" – this instructs you to reverse a portion of the array – just[count] elements starting at index[start];
//	"sort from [start] count [count]" – this instructs you to sort a portion of the array - [count] elements starting at index [start];
//	"rollLeft [count] times" – this instructs you to move all elements in the array to the left[count] times. On each roll, the first element is placed /    at/ the end of the array;
//	"rollRight [count] times" – this instructs you to move all elements in the array to the right[count] times. On each roll, the last element is placed /   at the beginning of the array;


class CommandInterpreter
{
    static void Main()
    {
        // Чете лист от стрингпве, сплитва и маха празните места
        List<string> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        // Чете входа на следващия ред
        string inputLine = Console.ReadLine();

        // Докато входа не е равен на end
        while (inputLine != "end")
        {
            // Сплитваме входа за да вземем параметрите
            string[] inputParams = inputLine.Split(' ');
            // Взимаме командата
            string command = inputParams[0];

            // Ако командата е
            switch (command)
            {
                case "reverse":
                    // Променливи за началния индекс и броя числа
                    int reverseStart = int.Parse(inputParams[2]);
                    int reverseCount = int.Parse(inputParams[4]);

                    // Ако началния индекс е по-голям от нула и е по-малък от дължината на масива и броя символи е по-голям от 0 и началния индекс + броя са по-малки от дължината на масива
                    if (reverseStart >= 0 && reverseStart < input.Count && reverseCount >= 0 && (reverseStart + reverseCount <= input.Count))
                    {
                        // Обръщане на масива (начален индекс, колко индекса)
                        input.Reverse(reverseStart, reverseCount);
                    }
                    // Ако не са
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    break;

                case "sort":
                    int sortStart = int.Parse(inputParams[2]);
                    int sortCount = int.Parse(inputParams[4]);

                    // Ако началния индекс е по-голям от нула и е по-малък от дължината на масива и броя символи е по-голям от 0 и началния индекс + броя са по-малки от дължината на масива
                    if (sortStart >= 0 && sortStart < input.Count && sortCount >= 0 && (sortStart + sortCount <= input.Count))
                    {
                        // Сортиране на масива (начален индекс, колко индекса, критерии)
                        input.Sort(sortStart, sortCount, null);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");

                    }
                    break;

                case "rollLeft":
                    int rollLeftCount = int.Parse(inputParams[1]);

                    // Броя на ротации трябва да е по-голям от 0
                    if (rollLeftCount >= 0)
                    {
                        // Цикъл по-броя ротации по модул дъжлината на масива = спестява време
                        for (int i = 0; i < rollLeftCount % input.Count; i++)
                        {
                            // Запазваме първия елемент
                            string firstElement = input[0];

                            // Цикъл по-масива-1
                            for (int j = 0; j < input.Count - 1; j++)
                            {
                                // Текущия символ е равен на следващия
                                input[j] = input[j + 1];
                            }
                            // Последния символ е равен на първия
                            input[input.Count - 1] = firstElement;
                        }
                    }
                    // Ако не отговаря на условието
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    break;

                case "rollRight":
                    int rollRightCount = int.Parse(inputParams[1]);

                    // Ротациите трябва да са по-големи от 0
                    if (rollRightCount >= 0)
                    {
                        // Цикъл до броя ротации делени по модул с дължината на масива = пести време
                        for (int i = 0; i < rollRightCount % input.Count; i++)
                        {
                            // Запазваме последния елемент
                            string lastElement = input[input.Count - 1];

                            // Обратен цикъл
                            for (int j = input.Count - 1; j > 0; j--)
                            {
                                // Текущия символ е равен на предходния
                                input[j] = input[j - 1];
                            }
                            // Първия елемент е равен на последния
                            input[0] = lastElement;
                        }
                    }
                    // АКо не отговаря на условето
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    break;
            }
            // Чете входа
            inputLine = Console.ReadLine();
        }
        // Принтира резултата
        Console.WriteLine("[{0}]", string.Join(", ", input));
    }
}