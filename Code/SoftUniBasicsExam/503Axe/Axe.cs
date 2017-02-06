using System;

//  Вход                    Изход
//  5	                    ---------------**--------
//                          ---------------*-*-------
//                          ---------------*--*------
//                          ---------------*---*-----
//                          ---------------*----*----
//                          ****************----*----
//                          ****************----*----
//                          ---------------*----*----
//                          --------------********---


class Axe
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int leftDash = n * 3;
        int star = 1;
        int rightDash = (n * 2) - 2;
        int middleDash = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('-', leftDash));
            Console.Write(new string('*', star));
            Console.Write(new string('-', middleDash));
            Console.Write(new string('*', star));
            Console.Write(new string('-', rightDash));
            Console.WriteLine();

            middleDash++;
            rightDash--;
        }

        middleDash--;
        rightDash++;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('*', leftDash));
            Console.Write(new string('*', star));
            Console.Write(new string('-', middleDash));
            Console.Write(new string('*', star));
            Console.Write(new string('-', rightDash));
            Console.WriteLine();
        }


        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.Write(new string('-', leftDash));
            Console.Write(new string('*', star));
            Console.Write(new string('-', middleDash));
            Console.Write(new string('*', star));
            Console.Write(new string('-', rightDash));
            Console.WriteLine();

            leftDash--;
            middleDash += 2;
            rightDash--;
        }


        Console.Write(new string('-', leftDash));
        Console.Write(new string('*', star));
        Console.Write(new string('*', middleDash));
        Console.Write(new string('*', star));
        Console.Write(new string('-', rightDash));
        Console.WriteLine();
    }
}