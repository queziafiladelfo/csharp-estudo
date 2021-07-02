﻿using System;
using System.Globalization;

namespace Exer03
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            
            double raio = double.Parse(Console.ReadLine());

            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");




        }
    }
}
