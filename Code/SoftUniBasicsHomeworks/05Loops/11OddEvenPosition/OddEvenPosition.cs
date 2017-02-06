using System;

    class OddEvenPosition
    {
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());

        double EvenSum = 0.0; double OddSum = 0.0;
        double EvenMin = Double.MaxValue; double OddMin = Double.MaxValue;
        double EvenMax = Double.MinValue; double OddMax = Double.MinValue;

        for (double i = 1; i <= n; i++)
        {
            double num = double.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                EvenSum += num;

                if (num > EvenMax) { EvenMax = num; }
                if (num < EvenMin) { EvenMin = num; }
            }
            else
            {
                OddSum += num;

                if (num > OddMax) { OddMax = num; }
                if (num < OddMin) { OddMin = num; }
            }
        }
        if (n == 0)
        {
            Console.WriteLine("OddSum=0,\nOddMin=No,\nOddMax=No\nEvenSum=0,\nEvenMin=No,\nEvenMax=No");
        }
        if (n == 1)
        {
            Console.WriteLine("OddSum={0},\nOddMin={1},\nOddMax={2}\nEvenSum=0,\nEvenMin=no,\nEvenMax=no"
                , OddSum, OddMin, OddMax);
        }
        else
        {
            Console.WriteLine("OddSum={0},\nOddMin={1},\nOddMax={2}", OddSum, OddMin, OddMax);
            Console.WriteLine("EvenSum={0},\nEvenMin={1},\nEvenMax={2},", EvenSum, EvenMin, EvenMax);
        }

    }
}
   
