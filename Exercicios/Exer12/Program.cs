﻿using System;

namespace Exer12
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while( tipo != 4)
            {
                if (tipo == 1)
                    alcool = alcool + 1;
                else if (tipo == 2)
                    gasolina = gasolina + 2;
                else if (tipo == 3) 
                {
                    diesel += 1;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nAlcool: " + alcool + "\n Gasolina: " + gasolina + "\n Diesel: " + diesel);
        }
    }
}
