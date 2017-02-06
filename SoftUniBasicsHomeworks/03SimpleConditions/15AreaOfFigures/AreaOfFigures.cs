using System;

// Да се напише програма, която въвежда размерите на геометрична фигура и пресмята лицето й.Фигурите са четири вида: 
// квадрат(square), правоъгълник(rectangle), кръг(circle) и триъгълник(triangle). 
// На първия ред на входа се чете вида на фигурата(square, rectangle, circle или triangle). 
// Ако фигурата е квадрат, на следващия ред се чете едно число – дължина на страната му.
// Ако фигурата е правоъгълник, на следващите два реда четат две числа – дължините на страните му. 
// Ако фигурата е кръг, на следващия ред чете едно число – радиусът на кръга.Ако фигурата е триъгълник, 
// на следващите два реда четат две числа – дължината на страната му и дължината на височината към нея. 
// Резултатът да се закръгли до 3 цифри след десетичната точка.
// 
// вход         изход       
// square       25
// 5	        	

class AreaOfFigures
{
    static void Main()
    {
        string figrures = Console.ReadLine();

        if (figrures == "square")
        {
            double lengthOfSide = double.Parse(Console.ReadLine());

            double areaOfSquare = lengthOfSide * lengthOfSide;

            Console.WriteLine(Math.Round(areaOfSquare, 3));
        }

        else if (figrures == "rectangle")
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double areaOfRectrangle = width * height;

            Console.WriteLine(Math.Round(areaOfRectrangle, 3));
        }

        else if (figrures == "circle")
        {
            double radius = double.Parse(Console.ReadLine());

            double areaOfCircle = Math.PI * (radius * radius);

            Console.WriteLine(Math.Round(areaOfCircle, 3));
        }

        else if (figrures == "triangle")
        {
            double baseSide = double.Parse(Console.ReadLine());
            double verticalHeight = double.Parse(Console.ReadLine());

            double areaOfTriangle = (baseSide * verticalHeight) / 2;

            Console.WriteLine(Math.Round(areaOfTriangle, 3));
        }
    }
}