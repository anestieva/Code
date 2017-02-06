using System;

//  5
//        |
//      * | *
//     ** | **
//    *** | ***
//   **** | ****
//  ***** | *****

class ChristmasTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int space = n+1;
        int middleSpace = 1;
        int star = 1;
        int line = 1;

        Console.Write(new string(' ', space));
        Console.Write(new string('|', line));
        Console.Write(new string(' ', space));
        Console.WriteLine();

        space = n - 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string(' ', space));
            Console.Write(new string('*', star));
            Console.Write(new string(' ', middleSpace));
            Console.Write(new string('|', line));
            Console.Write(new string(' ', middleSpace));
            Console.Write(new string('*', star));
            Console.Write(new string(' ', space));
            Console.WriteLine();

            star++;
            space--;
        }
    }
}