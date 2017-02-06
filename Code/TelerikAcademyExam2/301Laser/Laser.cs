using System;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

class Laser
{
    static void Main()
    {
        // Пренасочване на програмата да чете от файл, а не от txt
        if (File.Exists("input.txt"))
        {
            Console.SetIn(new StreamReader("input.txt"));
        }

        // Размерите на куба
        int[] dims = GetThreeNumbersFromConsole();
        // Начални позиции
        int[] pos = GetThreeNumbersFromConsole();
        // Посочни вектори
        int[] vec = GetThreeNumbersFromConsole();

        bool[,,] visited = new bool[dims[0] + 1, dims[1] + 1, dims[2] + 1];

        while (true)
        {
            visited[pos[0], pos[1], pos[2]] = true;
            int[] newPos = new int[3];
            // pos:    (2, 2, 2)
            // vec:    (1, 0, -1)
            // newPos: (3, 2, 1)
            for (int i = 0; i < 3; i++)
            {
                newPos[i] = pos[i] + vec[i];
            }

            // Ако е равно на 2 сме стигнали ръб
            if (visited[newPos[0], newPos[1], newPos[2]] ||
                HowManyIndexesAreLimit(newPos,dims) >= 2)
            {
                // Следващата позиция е посетена
                Console.WriteLine("{0} {1} {2}", pos[0], pos[1], pos[2]);
                return;
            }

            // Ако е равно на 1 сме стигнали стена
            if (HowManyIndexesAreLimit(newPos, dims) == 1)
            {
                ReverseComponent(newPos,vec, dims);
            }

            for (int i = 0; i < 3; i++)
            {
                pos[i] = newPos[i];
            }
        }
    }

    static void ReverseComponent(int[] newPos,int[] vec, int[] dims)
    {
        for (int i = 0; i < 3; i++)
        {
            if (newPos[i] == 1 && vec[i] == -1)
            {
                vec[i] *= -1;
            }
            else if(newPos[i] == dims[i] && vec[i] == 1)
            {
                vec[i] *= -1;
            }
        }
    }

    // Метод къде се намира в момента
    static int HowManyIndexesAreLimit(int[] pos, int[]dims)
    {
        int count = 0;
        for (int i = 0; i < 3; i++)
        {
            if (pos[i] == 1 || pos[i] == dims[i])
            {
                count++;
            }


        }
        return count;
    }
    

    static int[] GetThreeNumbersFromConsole()
    {
        string input = Console.ReadLine();
        string[] split = input.Split(' ');
        int[] array = new int[3];
        for (int i = 0; i < 3; i++)
        {
            array[i] = int.Parse(split[i]);
        }

        return split.Select(s => int.Parse(s)).ToArray();
    }
}