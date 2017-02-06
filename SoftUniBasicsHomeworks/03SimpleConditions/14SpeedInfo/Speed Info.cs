﻿using System;

// Да се напише програма, която въвежда скорост (десетично число) и отпечатва информация за скоростта. 
// При скорост до 10 (включително) отпечатайте “slow”. При скорост над 10 и до 50 отпечатайте “average”. 
// При скорост над 50 и до 150 отпечатайте “fast”. 
// При скорост над 150 и до 1000 отпечатайте “ultra fast”. При по-висока скорост отпечатайте “extremely fast”.
//
//  вход    изход
//  8	    slow


class SpeedInfo
    {
    static void Main()
    {
        double speed = double.Parse(Console.ReadLine());

        if (speed <= 10)
        {
            Console.WriteLine("slow");
        }
        else if (speed > 10 && speed <= 50)
        {
            Console.WriteLine("average");
        }
        else if (speed >50 && speed <= 150)
        {
            Console.WriteLine("fast");
        }
        else if (speed > 150 && speed <= 1000)
        {
            Console.WriteLine("ultra fast");
        }
        else
        {
            Console.WriteLine("extremely fast");
        }
    }
}