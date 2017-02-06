using System;

class CheckPrime
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool prime = true;

        if (number <= 1)
        {
            Console.WriteLine("Not Prime");
        }
        else
        {


            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}