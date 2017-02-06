using System;
using System.Numerics;

// 1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes = 3155673600 seconds = 3155673600000 milliseconds = 3155673600000000 
// microseconds = 3155673600000000000 nanoseconds

class CenturiesToNanoseconds
{
    static void Main()
    {
        byte centuries = byte.Parse(Console.ReadLine());
        int years = 100 * centuries;
        int days = (int)(years * 365.2422);
        int hours = 24 * days;
        ulong min = (ulong)(60 * hours);
        ulong sec = 60 * min;
        ulong milliSec = 1000 * sec;
        decimal microSec = 1000 * milliSec;
        decimal nanoSec = 1000 * microSec;

        // Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {min} minutes = {sec} seconds = {milliSec} milliseconds = {microSec} microseconds = {nanoSec} nanoseconds");

        Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
            centuries, years, days, hours, min, sec, milliSec, microSec, nanoSec);

    }
}