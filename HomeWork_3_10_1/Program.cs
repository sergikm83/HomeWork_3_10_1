﻿using System;

namespace HomeWork_3_10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число k: ");
            int k = int.Parse(Console.ReadLine());
            string result = k % 2 == 0 ? "четное" : "не четное";
            Console.WriteLine($"Число {k} - {result}");
        }
    }
}
