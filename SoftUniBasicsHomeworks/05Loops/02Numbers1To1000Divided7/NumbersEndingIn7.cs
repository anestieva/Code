﻿using System;

class NumbersEndingIn7
{
    static void Main()
    {
        for (int i = 1; i < 1000; i++)
        {
            if (i % 10 == 7)
            {
                Console.WriteLine(i);
            }
        }
    }
}