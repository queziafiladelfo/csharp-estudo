using System;
using System.Globalization;

namespace Exer09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x > 0.0) 
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine("Raiz = " + raiz.ToString("F3", CultureInfo.InvariantCulture));
                
                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                
            }

            Console.WriteLine("Número negativo");



        }
    }
}
