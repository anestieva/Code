using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TrackDownloader
{
    static void Main()
    {
        // Блеклист
        List<string> blacklistedWords = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        // Вход
        string filenames = Console.ReadLine();

        // Променлива, която запазва резултата
        List<string> result = new List<string>();

        // Докато входа не е равен на end
        while (filenames != "end")
        {
            // Булева, че е в блеклист
            bool isInBlacklist = false;

            // За всяка дума в блеклиста
            foreach (var word in blacklistedWords)
            {
                // Ако входа съдържа дума от блеклиста
                if (filenames.Contains(word))
                {
                    // Блеклист е true
                    isInBlacklist = true;
                    break;
                }
            }

            // Ако не е в блеклиста
            if (!isInBlacklist)
            {
                // Добави в резултата входа
                result.Add(filenames);
            }

            // Сортирай резултата
            result.Sort();

            filenames = Console.ReadLine();
        }
        // Принтира резултата
        Console.WriteLine(String.Join("\r\n", result));
    }
}