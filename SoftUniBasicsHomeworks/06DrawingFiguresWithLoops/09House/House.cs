using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int star = 0;
        int dash = (n / 2) - 1;
        int line = 1;

        if (n % 2 == 0)
        {
            star = 2;
            Console.Write(new string('-', dash));
            Console.Write(new string('*', star));
            Console.Write(new string('-', dash));
            Console.WriteLine();

            for (int i = 0; i < n / 2 - 1; i++)
            {
                star += 2;
                dash--;
                Console.Write(new string('-', dash));
                Console.Write(new string('*', star));
                Console.Write(new string('-', dash));
                Console.WriteLine();
            }
        }
        else
        {
            star = 1;
            dash = n / 2;
            Console.Write(new string('-', dash));
            Console.Write(new string('*', star));
            Console.Write(new string('-', dash));
            Console.WriteLine();

            for (int i = 0; i < n / 2; i++)
            {
                star += 2;
                dash--;
                Console.Write(new string('-', dash));
                Console.Write(new string('*', star));
                Console.Write(new string('-', dash));
                Console.WriteLine();
            }
        }

        star -= 2;
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('|', line));
            Console.Write(new string('*', star));
            Console.Write(new string('|', line));
            Console.WriteLine();
        }
    }
}