using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Placeholders
{
    static void Main()
    {
        string inputLine = Console.ReadLine();

        while (inputLine != "end")
        {
            // Сплитваме по ->, за да разделим двете части на входа
            string[] inputParams = inputLine.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            // Променлива за изречението = I have a {0} and a {1}
            string sentence = inputParams[0].Trim();
            // Променлива за елементите, с които ще заместваме = car, house
            string[] elements = inputParams[1].Trim().Split(new[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            // Цикъл до броя елементи
            for (int i = 0; i < elements.Length; i++)
            {
                // Променлива за текущия плейсходлер = {0}, {1}..
                string currentPlaceholder = "{" + i + "}";

                // В изречението ми замени всичко, което е равно на текущия плейсхолдер с елемента от i
                sentence = sentence.Replace(currentPlaceholder, elements[i]);
            }

            Console.WriteLine(sentence);

            inputLine = Console.ReadLine();
        }
    }
}