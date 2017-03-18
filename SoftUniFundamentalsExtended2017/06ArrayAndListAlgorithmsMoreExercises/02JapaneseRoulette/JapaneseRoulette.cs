using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class JapaneseRoulette
{
    static void Main()
    {
        var roulette = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var command = Console.ReadLine().Split(' ').ToList();

        var index = 0;
        bool oneDead = false;
        int deadPlayer = int.MaxValue;

        while (!oneDead)
        {
            string[] commandParams = command[index].Split(',');

            for (int i = 0; i < command.Count; i++)
            {
                string action = commandParams[1];
                var indexToMove = int.Parse(commandParams[0]);
                int currentIndex = i;

                switch (action)
                {
                    // Ако действието е на дясно 
                    case "Right":
                        currentIndex = Math.Abs(currentIndex + indexToMove) % roulette.Count;

                        if (roulette[currentIndex] == 1)
                        {
                            oneDead = true;
                            deadPlayer = i;
                            break;
                        }
                        else
                        {
                            currentIndex++;
                        }
                        break;

                    //  Ако действието е на ляво
                    case "Left":
                        currentIndex = (currentIndex - indexToMove) % roulette.Count;

                        if (currentIndex < 0)
                        {
                            currentIndex += roulette.Count;
                        }

                        if (roulette[currentIndex] == 1)
                        {
                            oneDead = true;
                            deadPlayer = i;
                            break;
                        }
                        else
                        {
                            currentIndex++;
                        }
                        break;
                }
                index++;
            }


            if (!oneDead)
            {
                Console.WriteLine("Everybody got lucky!");
                break;
            }
            else
            {
                Console.WriteLine("Game over! Player {0} is dead.", deadPlayer);
            }
        }
    }
}
