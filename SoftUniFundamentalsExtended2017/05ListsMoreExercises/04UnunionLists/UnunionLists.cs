using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UnunionLists
{
    static void Main()
    {
        var primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int j = 0; j < list.Count; j++)
            {
                if (primalList.Contains(list[j]))
                {
                    primalList.RemoveAll(x => x == list[j]);
                }
                else
                {
                    primalList.Add(list[j]);
                }
            }
        }

        primalList.Sort();
        Console.WriteLine(string.Join(" ", primalList));
    }
}