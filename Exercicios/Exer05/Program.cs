using System;
using System.Globalization;

namespace Exer05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número do funcionário: ");
            int numFuncionario = int.Parse(Console.ReadLine());
            Console.Write("Número de horas trabalhadas: ");
            int horasTrabalho = int.Parse(Console.ReadLine());
            Console.Write("Horas trabalhada: ");
            double horasValor = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Number = " + numFuncionario);
            Console.WriteLine($"Salary = {(horasTrabalho * horasValor).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
