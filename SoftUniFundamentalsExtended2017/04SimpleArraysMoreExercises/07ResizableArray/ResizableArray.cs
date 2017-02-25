using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ResizableArray
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();

        List<int> result = new List<int>();

        while (input[0] != "end")
        {

            if (input[0].Equals("push"))
            {
                result.Add(int.Parse(input[1]));
            }
            else if (input[0].Equals("pop"))
            {
                result.RemoveAt(result.Count - 1);
            }
            else if (input[0].Equals("removeAt"))
            {
                result.RemoveAt(int.Parse(input[1]));
            }
            else if (input[0].Equals("clear"))
            {
                result.Clear();
            }

            input = Console.ReadLine().Split(' ').ToArray();
        }

        if (result == null || result.Count == 0)
        {
            Console.WriteLine("empty array");
        }
        else
        {
            Console.WriteLine(String.Join(" ", result));
        }
    }
}