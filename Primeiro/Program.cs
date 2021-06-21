/*
* referencia para o namespace chamado 'System'
* esse namespace é padrão do dotnet que contem funções básicas de manipulação de programas, 
*então para que se possa utiliza-las no programa se deve colocar essa referência para 
* que seja pos´´ivel o programa enxergar a função
*/
using System;


/*
* Declaração de namespace desse arquivo
* aqui se declara que o programa (no caso a class Program) está dentro do namespace 'Primeiro'.
* Esse namespace não é obrigatório, se tira-lo o programa continua funcionando, mas por questões de 
* boas práticas e organização é sempre recomendado colocar as classes dentro de namespaces
*/
namespace Primeiro
{
    class Program
    {
        //menbro da classe Program
        /*
        * declaração padrão para identificar o entry point da aplicação
        */
        static void Main(string[] args)
        {
            // Exemplo: 'Console.WriteLine' pertence ai namespace 'System'
            Console.WriteLine("Hello World!");
        }
    }
}
