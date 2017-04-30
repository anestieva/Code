using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class File
{
    static void Main()
    {
        // Речник, в който ще пазим резултата
        var dictionary = new Dictionary<string, Dictionary<string, long>>();

        // Променлива за n
        var n = int.Parse(Console.ReadLine());

        // Цикъл до n
        for (int i = 0; i < n; i++)
        {
            // Чете входа и го сплитва по ю
            var currentFileData = Console.ReadLine().Split('\\');

            // Променлива за първата локация на файла
            var fileRoot = currentFileData[0];

            // Сплитваме втората част на локацията на файла по ;
            var fileNameExtensionAndSize = currentFileData[currentFileData.Length - 1].Split(';');
            // Променлива за разширението на файла
            var fileNameAndExtension = fileNameExtensionAndSize[0];
            // Променлива за размера на файла
            var fileSize = long.Parse(fileNameExtensionAndSize[1]);

            // Ако речника не съдържа локацията на файла
            if (!dictionary.ContainsKey(fileRoot))
            {
                // Създай в речника локацията
                dictionary[fileRoot] = new Dictionary<string, long>();
            }

            // Добави в [локацията][разширението на файла] = размера на файла
            dictionary[fileRoot][fileNameAndExtension] = fileSize;
        }

        // Променлива за файловете, които търсим сплитната по спейс
        var filesToSearch = Console.ReadLine().Split().ToList();
        // Променлива за разширението
        var extension = filesToSearch[0];
        // Променлива за локацията
        var root = filesToSearch[2];

        // Ако създадения речник не съдържа локацията
        if (!dictionary.ContainsKey(root))
        {
            // Принтирай No
            Console.WriteLine("No");
            Environment.Exit(1);
        }

        // Създаваме нов речник от текущия
        var resultDictionary = dictionary[root]
            // където ключа завършва с разширението
            .Where(x => x.Key.EndsWith(extension))
            // Сортирани са по стойност
            .OrderByDescending(x => x.Value)
            // След това по ключ
            .ThenBy(x => x.Key)
            // Към речник
            .ToDictionary(x => x.Key, y => y.Value); ;

        // Ако речника е 0
        if (resultDictionary.Count == 0)
        {
            Console.WriteLine("No");
            Environment.Exit(1);
        }

        // Принтираме резултата
        foreach (var file in resultDictionary)
        {
            Console.WriteLine($"{file.Key} - {file.Value} KB");
        }
    }
}
