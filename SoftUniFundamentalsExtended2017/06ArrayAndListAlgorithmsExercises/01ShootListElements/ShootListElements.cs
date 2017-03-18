using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ShootListElements
{
    static void Main()
    {
        string text = Console.ReadLine();
        char[] array = text.ToCharArray();

        int sum = 0;
        int lenght = 0;

        for (int i = 0; i < array.Length; i++)
        {
            char letter = array[i];
            if (letter != 32)
            {
                sum += letter;
                lenght++;
            }
        }

        char symbol = (char)(sum / lenght);
        symbol = char.ToUpper(symbol);

        for (int i = 0; i < text.Length; i++)
        {
            char letter = array[i];
            if (letter == 32)
            {
                letter = symbol;
            }
            Console.Write(letter);
        }
        Console.WriteLine();
    }
}