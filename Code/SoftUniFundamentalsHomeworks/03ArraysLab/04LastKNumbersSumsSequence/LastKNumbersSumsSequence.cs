using System;

class LastKNumbersSumsSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        arr[0] = 1;
        for (int i = 1; i < n; i++)
        {
            arr[i] = SumNums(arr, i - k, i - 1);
        }
        Console.WriteLine("Sequence: ");
        Console.WriteLine(String.Join(" ", arr));
    }

    private static int SumNums(int[] arr, int startIndex, int endIndex)
    {
        int sum = 0;
        for (int i = startIndex; i <= endIndex; i++)
        {
            if (i >= 0)
            {
                sum += arr[i];
            }
        }
        return sum;
    }
}