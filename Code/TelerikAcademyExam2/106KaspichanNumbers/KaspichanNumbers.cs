using System;
using System.Collections.Generic;

class KaspichanNumbers
{
    static void Main()
    {
        // Чете входа
        ulong n = ulong.Parse(Console.ReadLine());
        // Създаваме лист
        List<string> digits = new List<string>();

        // Цикъл от А до Z
        for (char i = 'A'; i <= 'Z'; i++)
        {
            digits.Add(i.ToString());
        }

        // Цикъл от iA до zA
        for (char i = 'a'; i <= 'z'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                digits.Add(i.ToString() + j.ToString());
            }
        }

        string result = "";

        if (n == 0)
        {
            Console.WriteLine("A");
        }
        while (n != 0)
        {
            result = digits[(int)(n % 256)] + result;
            n = n / 256;
        }
        Console.WriteLine(result);


    // Принтира
    //   foreach (var item in digits)
    //   {
    //       Console.Write(item + " ");
    //   }

    }
}