using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GroupContinentsCountriesAndCities
{
    static void Main()
    {
        // Сортиран речник, който пази континентите, със сортиран речник, който пази държавите, със сортиран сет, който пази градовете
        var data = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

        // Броя редове
        var n = int.Parse(Console.ReadLine());

        // Цикъл до броя редове
        for (int i = 0; i < n; i++)
        {
            // Сплитва входа
            var tokens = Console.ReadLine().Split(' ');

            // Взима континента, държавата и града
            var continent = tokens[0];
            var country = tokens[1];
            var town = tokens[2];

            // Ако в речника не се съдържа континента
            if (!data.ContainsKey(continent))
            {
                // Добави континента
                data[continent] = new SortedDictionary<string, SortedSet<string>>();
            }

            // Ако в речника с континенти не се сърдържа държавата
            if (!data[continent].ContainsKey(country))
            {
                // Добави държавата
                data[continent][country] = new SortedSet<string>();
            }

            // В речника от континент и държава добави града
            data[continent][country].Add(town);
        }

        // Принтиране на речника
        foreach (var continentAndCountries in data)
        {
            var continentName = continentAndCountries.Key;
            var townsByCountry = continentAndCountries.Value;

            Console.WriteLine("{0}:", continentName);

            foreach (var item in townsByCountry)
            {
                var country = item.Key;
                var towns = item.Value;

                Console.WriteLine("{0} -> {1}", country, string.Join(", ", towns));
            }

        }
    }
}