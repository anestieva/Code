using System;

//  вход                изход
//  3	                ...._______....
//                      ...//_____\\...
//                      ..//_______\\..
//                      .//_________\\.
//                      //___STOP!___\\
//                      \\___________//
//                      .\\_________//.
//                      ..\\_______//..


class Stop
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int point = n + 1;
        int underscore = (n * 2) + 1;
        int leftSlash = 2;
        int rightSlash = 2;

        Console.Write(new string('.', point));
        Console.Write(new string('_', underscore));
        Console.Write(new string('.', point));
        Console.WriteLine();

        point--;
        underscore -= 2;

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', point));
            Console.Write(new string('/', leftSlash));
            Console.Write(new string('_', underscore));
            Console.Write(new string('\\', rightSlash));
            Console.Write(new string('.', point));
            Console.WriteLine();

            point--;
            underscore += 2;
        }


        Console.Write(new string('/', leftSlash));
        Console.Write(new string('_', n * 2 - 3));
        Console.Write("STOP!");
        Console.Write(new string('_', n * 2 - 3));
        Console.Write(new string('\\', rightSlash));
        Console.WriteLine();

        leftSlash = 2;
        rightSlash = 2;
        underscore = n * 4 -1;
        point = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', point));
            Console.Write(new string('\\', rightSlash));
            Console.Write(new string('_', underscore));
            Console.Write(new string('/', leftSlash));
            Console.Write(new string('.', point));
            Console.WriteLine();

            point++;
            underscore -= 2;
        }
    }
}