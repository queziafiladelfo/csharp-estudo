using System;

namespace Exer07
{
    class Program
    {
        static void Main(string[] args)
        {
            // se numero é par ou impar
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0) 
            {
                Console.WriteLine($"{numero} é um número par.");
            }
            else
            {
                Console.WriteLine($"{numero} é um número impar.");
            }

            Console.Write("Digite uma hora: ");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)             
                Console.WriteLine("Bom dia!!!");            
            else if ( hora < 18)            
                Console.WriteLine("Boa tarde!!!");    
            else 
                Console.WriteLine("Boa noite!!!");  
        
        }        
    }
}
