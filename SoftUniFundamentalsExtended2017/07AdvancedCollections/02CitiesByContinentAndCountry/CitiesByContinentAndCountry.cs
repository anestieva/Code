using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CitiesByContinentAndCountry
{
    static void Main()
    {
        // Декларираме речник, който съдържа речник
        var towns = new Dictionary<string, Dictionary<string, List<string>>>();
        
        // Чете броя редове
        int n = int.Parse(Console.ReadLine());

        // Цикъл до броя редове
        for (int i = 0; i < n; i++)
        {
            // Чете реда и сплитва
            var line = Console.ReadLine().Split();
            // Променливи за континент, държава и град
            var continent = line[0];
            var country = line[1];
            var town = line[2];

            // Метод, който записва в речника
            AddTown(towns, continent, country, town);
        }

        // Цикъл, който принтира резултата (от речника върви по континентите)
        foreach (var continent in towns.Keys)
        {
            // Принтира текущия континент
            Console.WriteLine("{0}:", continent);
            // Променлива, която пази текущия континент
            var townsInContinent = towns[continent];
            // Цилъл по текущия континент (принтира държавите и градовете)
            foreach (var country in townsInContinent.Keys)
            {
                Console.WriteLine("  {0} -> {1}", country, string.Join(", ", townsInContinent[country]));
            }
        }


    }

    // Метод, който добавя градовете
    private static void AddTown(Dictionary<string, Dictionary<string, List<string>>> towns, string continent, string country, string town)
    {
        // Ако в речника не съществува текущия континент
        if (!towns.ContainsKey(continent))
        {
            // Добави континента
            towns[continent] = new Dictionary<string, List<string>>();
        }

        // Ако в речника не съществува текущата държава
        if (!towns[continent].ContainsKey(country))
        {
            // Добави текущата държава
            towns[continent][country] = new List<string>();
        }
        // Добави града в текущия континент и държава
        towns[continent][country].Add(town);
    }  
}