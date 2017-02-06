using System;

//  Вход            Изход
//  4               ....************....
//                  ...*............*...
//                  ..*..............*..
//                  .*................*.
//                  ********************
//                  .*................*.
//                  ..*..............*..
//                  ...*............*...
//                  ....*..........*....
//                  .....*........*.....
//                  ......*......*......
//                  .......*....*.......
//                  ........*..*........
//                  .........**.........

class Diamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dot = n;
        int star = n * 3;
        int middleDot = n * 3;

        Console.Write(new string('.', dot));
        Console.Write(new string('*', star));
        Console.Write(new string('.', dot));
        Console.WriteLine();

        dot--;


        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string('.', dot));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', middleDot));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', dot));
            Console.WriteLine();

            dot--;
            middleDot += 2;
        }

        Console.Write(new string('*', n * 5));
        Console.WriteLine();

        dot = 1;
        middleDot -= 2;

        for (int i = 0; i < n * 2; i++)
        {
            Console.Write(new string('.', dot));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', middleDot));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', dot));
            Console.WriteLine();

            dot++;
            middleDot -= 2;
        }

        Console.Write(new string('.', dot));
        Console.Write(new string('*', n-2));
        Console.Write(new string('.', dot));
        Console.WriteLine();
    }
}