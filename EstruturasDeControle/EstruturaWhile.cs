using System;

namespace Csharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativas = 5;


            while (numeroEncontrado != true && tentativas != 0)
            {
                System.Console.WriteLine("Qual o número secreto ? ");
                tentativas--;
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);
                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    System.Console.WriteLine("Acertou mizeravel ! ");
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Diminui isso aê ! ");
                    System.Console.WriteLine();
                }
                else
                {
                    System.Console.WriteLine("Aumenta isso aê !! Tá com dó ?");
                    System.Console.WriteLine();
                }
            }

        }
    }
}