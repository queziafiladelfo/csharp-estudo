using System;

namespace Tipos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * sbyte : um tipo pre-defino
            * SByte : um tipo do dotnte (se eu tirar o 'using System', ele para de funcionar)
            */
            SByte x = 100;
            
            // o byte é um exemplo de número que nao aceita sinal, ele não tem numeros negativos
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647; // valor máximo suportado pelo tipo 'int'
            long n4 = 2147483648L; // é recomendavel quando for escrever um numero assim para guardar no tipo 'long' colocar o sufixo 'L' no final para indicar explicitamente que se esta trabalhando com long
            
            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            char genero = 'F'; //valores char se usa aspas simples
            Console.WriteLine(genero);

            char laranja = '\u0041'; //unicode da letra 'A'
            Console.WriteLine(laranja);
            

            //tipos lógicos (guardam valores verdade: true or false)
            bool completo = false;
            Console.WriteLine(completo); //Saida: false

            //ponto flutuante
            float n5  = 4.5f;
            double n6 = 4.5;
            Console.WriteLine(n5);
            Console.WriteLine(n6); // a saida vai pegar o padrao da lingua do computador sai 4,5 pq a virgula é padrão no brasil, isso pode ser mudado no programa

            // tipo string: representa um texto, uma frase
            string nome = "Maria"; // em string se usa aspas duplas
            Console.WriteLine(nome);

            /*
            * a string não é considerada um tipo básico do C#
            * O string é uma cadeia de caracteres UNICODE e ele é IMUTÁVEL(segurança, simplicidade, thread safe)
            * uma vez que você cria uma variavel do tipo string você não pode mais alterar o valor dela
            * é um forma de deixar o programa mais seguro e livrve de erros
            */    

            // Tipo Object
            /*
            * Ele é um objeto genérico, ou seja, toda classe em C# ele é uma subclasse e Object
            */

            object obj1 = "Alex Silva"; // ele aceita qualquer coisa
            object obj2 = 4.5f;
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);


            // Funções para valores mínimos e máximos
            /*
            * int.MinValue
            * int.MaxValue
            * sbyte.MaxValue
            * long.MaxValue
            * decimal.MaxValue
            * etc...
            *
            * dentro do proprio tipo existe uma propriedade que vai falar qual o max e o min suportado
            * por aquele tipo

            */

            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            Console.WriteLine(n7);
            Console.WriteLine(n8);


        }
    }
}
