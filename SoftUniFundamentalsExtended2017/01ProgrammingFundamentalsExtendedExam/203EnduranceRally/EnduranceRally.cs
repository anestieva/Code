using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EnduranceRally
{
    static void Main()
    {
        // Променлива за шофьорите
        string[] drivers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        // Променлива за пистата
        double[] track = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
        // Променлива за чекпойнт
        int[] checkpoints = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        // Цикъл за всеки шофьор
        foreach (var driver in drivers)
        {
            // Променлива, с която взимаме стойността на първата буква на всеки шофьор по ASCII
            double fuel = driver[0];

            // Цикъл по пистата
            for (int i = 0; i < track.Length; i++)
            {
                // Променлива за числото на пистата
                var currentZone = track[i];

                // Ако чекпойнта съвпада с индекса
                if (checkpoints.Contains(i))
                {
                    // Към горивото добавяме стойността 
                    fuel += currentZone;
                }
                // АКо не е чекпойнт
                else
                {
                    // От горивото изваждаме стойността
                    fuel -= currentZone;
                }

                // Ако горивото е по-малко или равно на 0
                if (fuel <= 0)
                {
                    // Горивото е свършило и принтираме шофьора и индекса, на който е свършил
                    Console.WriteLine("{0} - reached {1}", driver, i);
                    // Прекъсваме цикъла
                    break;
                }
            }

            // Ако горивото е повече от 0
            if (fuel > 0)
            {
                // Шофьора е завършил състезанието и принтираме шофьора и с колко гориво е завършил
                Console.WriteLine("{0} - fuel left {1:F2}", driver, fuel);
            }
        }
    }
}