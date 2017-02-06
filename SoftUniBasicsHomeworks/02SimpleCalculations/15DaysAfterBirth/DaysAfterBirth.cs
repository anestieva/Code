using System;
using System.Globalization;

class DaysAfterBirth
{
    static void Main()
    {
        string dateString = Console.ReadLine();
        string format = "dd-MM-yyyy";
        DateTime result = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);
        CultureInfo provider = CultureInfo.InvariantCulture;
        DateTime output = Convert.ToDateTime(result).AddDays(999);

        Console.WriteLine(output.ToString("dd-MM-yyyy"));
    }
}