using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  You are an airplane pilot, trying to maneuver your airplane to safety from an unknown danger.
//  An array holds a sequence of up / down commands and numbers.Its first element always holds the initial altitude.
//  The command up increases the altitude by the next number, while the command down decreases the altitude by the next number.
//  If at any point the altitude becomes either zero or negative, print “crashed” and end the program. 
//  If by the end, the altitude is positive, however, print “got through safely.current altitude: { altitude}m”.

//  0       1       2    3      4    5     6
//  300     up      3    down   7    up    5

class Altitude
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        long altitude = long.Parse(input[0]);

        for (int i = 1, j = 2; i < input.Length; i++, j++)
        {
            if (input[i] == "up")
            {
                altitude += long.Parse(input[j]);
            }
            if (input[i] == "down")
            {
                altitude -= long.Parse(input[j]);
            }

            if (altitude <= 0)
            {
                Console.WriteLine("crashed");
                break;
            }
        }

        if (altitude > 0)
        {
            Console.WriteLine("got through safely. current altitude: {0}m", altitude);
        }
    }
}