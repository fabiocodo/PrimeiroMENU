using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            bool continua = true;
            do
            {
                Console.WriteLine("Exercicio vetor - Opções");
                Console.WriteLine("1- Exercicio 1 ");
                Console.WriteLine("2- Exercicio 2 ");
                Console.WriteLine("3- Exercicio 3 ");
                Console.WriteLine("4- Exercicio 4 ");
                Console.WriteLine("5- Sair ");
                Console.WriteLine("Entre com a opção escolhida");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: ex01(); break;
                    case 2: ex02(); break;
                    case 3: ex03(); break;
                    case 4: ex04(); break;
                    case 5: continua = false; break;
                    default: Console.WriteLine("Opção inválida"); break;
                }
                // declarando o vetor:
            } while (continua);

        }
        static void ex01()
        {
          
        }
        static void ex02()
        {

        }
        static void ex03()
        {

        }
        static void ex04()
        {
           
        }
    }
}
