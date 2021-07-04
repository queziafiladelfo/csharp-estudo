using System;

namespace Exer10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Senha: ");
            int senha = int.Parse(Console.ReadLine());

            while(senha != 2002) {
                Console.Write(" - Senha invalida, tente novamente. \n");
                Console.Write("Senha: ");
                senha = int.Parse(Console.ReadLine());

            }

            Console.Write(" - Senha válida.");
        }
    }
}
