using System;

class HalfSumElement
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int maxNum = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            sum += num;

            if (num > maxNum)
            {
                maxNum = num;
            }
        }

        if (sum - maxNum == maxNum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = {0}", maxNum);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Diff = {0}", Math.Abs((sum - maxNum) - maxNum));
        }
    }
}