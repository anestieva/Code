using System;

class TradeComissions
{
    static void Main()
    {
        string town = Console.ReadLine();
        double sales = double.Parse(Console.ReadLine());

        double comision = 0;

        if (town == "Sofia")
        {
            if (sales >= 0 && sales <= 500)
            {
                comision = sales * 0.05;
            }
            else if (sales > 500 && sales <= 1000)
            {
                comision = sales * 0.07;
            }
            else if (sales >1000 && sales <= 10000)
            {
                comision = sales * 0.08;
            }
            else if (sales > 10000)
            {
                comision = sales * 0.12;
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.WriteLine(comision);
        }

        else if (town == "Varna")
        {
            if (sales >= 0 && sales <= 500)
            {
                comision = sales * 0.045;
            }
            else if (sales > 500 && sales <= 1000)
            {
                comision = sales * 0.075;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                comision = sales * 0.10;
            }
            else if (sales > 10000)
            {
                comision = sales * 0.13;
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.WriteLine(comision);
        }

        else if (town == "Plovdiv")
        {
            if (sales >= 0 && sales <= 500)
            {
                comision = sales * 0.055;
            }
            else if (sales > 500 && sales <= 1000)
            {
                comision = sales * 0.08;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                comision = sales * 0.12;
            }
            else if (sales > 10000)
            {
                comision = sales * 0.145;
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.WriteLine(comision);
        }

        else
        {
            Console.WriteLine("error");
        }
    }
}