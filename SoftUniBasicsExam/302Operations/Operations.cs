using System;

//  Вход                Изход
//  10                  10 + 12 = 22 - even
//  12
//  +

class Operations
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        string symbol = Console.ReadLine();

        if (symbol == "+")
        {
            double result = firstNumber + secondNumber;
            string divide = "";
            if (result % 2 == 0)
            {
                divide = "even";
            }
            if (result %2 != 0)
            {
                divide = "odd";
            }
            Console.WriteLine("{0} + {1} = {2} - {3}", firstNumber,secondNumber,result,divide);
        }

        if (symbol == "-")
        {
            double result = firstNumber - secondNumber;
            string divide = "";
            if (result % 2 == 0)
            {
                divide = "even";
            }
            if (result % 2 != 0)
            {
                divide = "odd";
            }
            Console.WriteLine("{0} - {1} = {2} - {3}", firstNumber, secondNumber, result, divide);
        }

        if (symbol == "*")
        {
            double result = firstNumber * secondNumber;
            string divide = "";
            if (result % 2 == 0)
            {
                divide = "even";
            }
            if (result % 2 != 0)
            {
                divide = "odd";
            }
            Console.WriteLine("{0} * {1} = {2} - {3}", firstNumber, secondNumber, result, divide);
        }

        if (symbol == "/")
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", firstNumber);
                
            }
            if (secondNumber > 0)
            {
                double result = firstNumber / secondNumber;

                Console.WriteLine("{0} / {1} = {2:F2}", firstNumber, secondNumber, result);
            }          
        }

        if (symbol == "%")
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", firstNumber);

            }
            if (secondNumber > 0)
            {
                double result = firstNumber % secondNumber;

                Console.WriteLine("{0} % {1} = {2}", firstNumber, secondNumber, result);
            }
        }
    }
}