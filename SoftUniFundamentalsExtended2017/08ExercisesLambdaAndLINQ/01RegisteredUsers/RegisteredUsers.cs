using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RegisteredUsers
{
    static void Main()
    {
        // Чете входа
        string input = Console.ReadLine();

        // Декларираме речник
        Dictionary<string, DateTime> result = new Dictionary<string, DateTime>();

        // Докато командата не е end
        while (input != "end")
        {
            // Сплитваме входа
            string[] token = input.Split(new[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Взимаме първия елемент
            string user = token[0];
            // Взимаме втория елемент и го парсваме към дата
            DateTime date = DateTime.ParseExact(token[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

            // Добавяме в речника
            result.Add(user, date);

            input = Console.ReadLine();
        }

        Dictionary<string, DateTime> orderedNames = result
            // Обръщаме резултата заради сортирането (последния влязъл да е първи)
            .Reverse()
            // Сортираме по стойност (дата)
            .OrderBy(x => x.Value)
            // Взимаме първите 5
            .Take(5)
            // Отново сортираме
            .OrderByDescending(x => x.Value)
            // Направи към речник
            .ToDictionary(x => x.Key, x => x.Value);

        // Принтиране на речник
        foreach (var user in orderedNames)
        {
            // Променлива за ключ
            var users = user.Key;
            // Променлива за стойност
            var date = user.Value;

            // Принтиране на резултата
            Console.WriteLine("{0}", users);
        }
    }
}