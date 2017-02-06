using System;

class PrimeChecker
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        IsPrime(n);
    }

    private static void IsPrime(int n)
    {
        bool isPrime = true;

        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            if (n % i != 0)
            {
                isPrime = true;
            }
            else
            {
                isPrime = false;
            }
        }
        Console.WriteLine(isPrime);
    }
}