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
        var population = new Dictionary<string, Dictionary<string, int>>();

        // Добавяме речник България, Градовете и населението
        population["Bulgaria"] = new Dictionary<string, int>();
        population["Bulgaria"]["Sofia"] = 1200000;
        population["Bulgaria"]["Plovdiv"] = 700000;

        // Добавяме речник Германия, Градовете и населението
        population["Germany"] = new Dictionary<string, int>();
        population["Germany"]["Munich"] = 2500000;
        population["Germany"]["Berlin"] = 1500000;

        // Метод, който добавя речник с държава, град и население
        AddPopulation(population, "USA", "New York", 111111000);

        // Принтиране на резултата - цикъл по основния речник
        foreach (var country in population.Keys)
        {
            // Принтираме държавата
            Console.WriteLine("Country {0}: ", country);
            // Променлива за текущия град
            var populationByTown = population[country];

            // Цикъл по текущия град
            foreach (var town in populationByTown.Keys)
            {
                // Принтираме града и населението
                Console.WriteLine("Town {0} -> {1} citiens", town, populationByTown[town]);
            }
        }

    }

    // Метод с който добавяме държава, град и население
    private static void AddPopulation(Dictionary<string, Dictionary<string, int>> population, string country, string town, int townPopulation)
    {
        // Ако текущата държава я няма в речника
        if (!population.ContainsKey(country))
        {
            // Създай текущата държава
            population[country] = new Dictionary<string, int>();
        }
        // Добави на текущата държава, и град = население
        population[country][town] = townPopulation;
    }
}