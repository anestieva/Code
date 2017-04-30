using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SoftUniKaraoke
{
    static void Main()
    {
        // Чете входа от участници: Trifon, Vankata, Gesha
        string[] users = Console.ReadLine().Split(',').Select(a => a.Trim()).ToArray();
        // Чете входа от песни: Dragana - Kukavice, Bon Jovi - It's my life, Lorde - Royals
        string[] songs = Console.ReadLine().Split(',').Select(a => a.Trim()).ToArray();

        // Речник за резултата, който пази стринг за участниците и сортиран сет за наградите
        Dictionary<string, SortedSet<string>> result = new Dictionary<string, SortedSet<string>>();

        // Чете входа
        string input = Console.ReadLine();

        // Докато входа не е dawn
        while (input != "dawn")
        {
            // Променлива, която сплитва входа
            string[] tokens = input.Split(',').Select(a => a.Trim()).ToArray();

            // Променлива за участника
            string user = tokens[0];
            // Променлива за песента
            string song = tokens[1];
            // Променлива за наградата
            string award = tokens[2];

            // Ако песента се съдържа в песните и участника в участниците
            if (songs.Contains(song) && users.Contains(user))
            {
                // Ако в резултата го няма участника
                if (!result.ContainsKey(user))
                {
                    // Създай в резултата нов участник със сортиран сет, който ще пази наградите
                    result[user] = new SortedSet<string>();
                }
                // Добави към участника наградата
                result[user].Add(award);
            }
            // Прочети отново входа
            input = Console.ReadLine();
        }

        // Ако в резултата нямаме записано нищо
        if (!result.Any())
        {
            // Принтирай
            Console.WriteLine("No awards");
            // Прекрати
            return;
        }

        // Сортирай резултата
        var sortedResult = result
            // Първо сортирай по броя на наградите
            .OrderByDescending(a => a.Value.Count)
            // После сортирай по име участниците
            .ThenBy(a => a.Key)
            // Запиши резултата в речник
            .ToDictionary(a => a.Key, a => a.Value);


        // Цикъл по сортирания речник
        foreach (var sortedUser in sortedResult)
        {
            // Променлива за участника
            var user = sortedUser.Key;
            // Променлива за наградата
            var awards = sortedUser.Value;

            // Принтирай участника и броя му награди
            Console.WriteLine("{0}: {1} awards", user,awards.Count);

            // Цикъл по наградите
            foreach (var award in awards)
            {
                // Принтирай наградите
                Console.WriteLine("--{0}", award);
            }
        }
    }
}