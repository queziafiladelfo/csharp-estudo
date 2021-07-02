using System;

namespace Exer04
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            Console.Write("Entre com o Valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Valor de B: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Valor de C: ");
            C = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Valor de D: ");
            D = int.Parse(Console.ReadLine());

            int diferanca = (A * B - C * D);

            Console.WriteLine("DIFERENÇA = " + diferanca);

        }
    }
}
