using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RecordUniqueNames
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        HashSet<string> uniqueNames = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            uniqueNames.Add(input);
        }

        Console.WriteLine(string.Join("\r\n", uniqueNames));
    }
}