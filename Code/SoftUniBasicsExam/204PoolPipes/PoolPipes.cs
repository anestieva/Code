using System;

//  Вход                Изход   
//  1000                The pool is 66% full.Pipe 1: 45%. Pipe 2: 54%.
//  100
//  120
//  3		
//
//  Обяснения
//  За 3 часа:
//  Първата тръба е напълнила – 300 л.
//  Втората тръба е напълнила – 360 л.
//  Общо – 660 л. < 1000 л. => 66% са запълнени
//  Първата тръба е допринесла с 45% (300 от 660 л.).
//  Втората тръба е допринесла с 54% (360 от 660 л.).

class PoolPipes
{
    static void Main()
    {
        double poolCapacity = double.Parse(Console.ReadLine());
        double firstPipe = double.Parse(Console.ReadLine());
        double secondPipe = double.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());

        double result = (firstPipe * hours) + (secondPipe * hours);

        if (result <= poolCapacity)
        {
            double percentagePool = Math.Floor((result / poolCapacity) * 100); // Math.Truncate
            double firstPrecent = Math.Floor(((firstPipe * hours) / result) * 100); // Math.Truncate
            double secondPrecent = Math.Floor(((secondPipe * hours) / result) * 100); // Math.Truncate

            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", percentagePool, firstPrecent, secondPrecent);
        }
        else
        {
            double overflows = result - poolCapacity;
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, overflows);
        }
    }
}