using System;
namespace Csharp.Fundamentos {
    class LendoDados{
        public static void Executar(){
            Console.WriteLine("Qual é seu nome ? " );
            string nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade ? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu salário : ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"O seu nome é {nome} você possui {idade} anos e você recebe {salario}");


        }

    }
}
