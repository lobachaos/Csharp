using System;
namespace Csharp.EstruturasDeControle
{
    class Break
    {
        public static void Executar()
        {
            Random random = new Random();
            int sorteio = random.Next(1, 40);


            for (int i = 1; i <= 40; i++)
            {
                System.Console.WriteLine($"{i} é o numero que queremos ? ");
                if (i == sorteio){
                    System.Console.WriteLine("Sim ! ");
                    break;
                }  else {
                    System.Console.WriteLine("Não ! ");
                }
            }



        }
    }
}