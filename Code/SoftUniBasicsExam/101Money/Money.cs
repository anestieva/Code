using System;

//  Вход	            Изход	
//  1                   569.668717948718
//  5
//  5		
//  
//  Обяснения
//  1 биткойн = 1168 лева
//  5 юана = 0.75 долара
//  0.75 долара = 1.32 лева
//  1168 + 1.32 = 1169.32 лева = 599.651282051282 евро
//  Комисионна: 5% от 599.651282051282 = 29.9825641025641
//  Резултат: 599.651282051282 - 29.9825641025641 = 569.668717948718 евро

class Money
{
    static void Main()
    {
        double bitcoin = double.Parse(Console.ReadLine());
        double uana = double.Parse(Console.ReadLine());
        double commission = double.Parse(Console.ReadLine());

        double bitcoinInLeva = bitcoin * 1168;
        double uanaInLeva = (uana * 0.15) * 1.76;

        double result = (bitcoinInLeva + uanaInLeva) / 1.95;
        result = result - (result * commission / 100);

        Console.WriteLine(result);
    }
}