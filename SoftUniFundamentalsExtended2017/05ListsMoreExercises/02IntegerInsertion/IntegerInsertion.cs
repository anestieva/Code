using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntegerInsertion
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        string input = Console.ReadLine();

        while (input != "end")
        {
            int numberToInsert = int.Parse(input);
            int index = int.Parse(input);
            while (index>9)
            {
                index /= 10;
            }
            numbers.Insert(index, numberToInsert);

            input = Console.ReadLine();
        }
        Console.WriteLine(String.Join(" ", numbers));
    }
}