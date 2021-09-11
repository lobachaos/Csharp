using System;

namespace Csharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar(){
            

            double r = 4.5;
           
            const double PI = 3.14;

            double area = r * PI ;

            Console.WriteLine("A area é : " + area);

            sbyte saldoGols = sbyte.MinValue; // s - > Signed 
            Console.WriteLine("Saldo de Gols : " + saldoGols);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor inteiro : " + menorValorInt);

            uint populacao = 207_600_000; // aceita _ para separar casas ; u -> Unsigned 
            Console.WriteLine("População Total : " + populacao);

            decimal velocidadeEstrelas = decimal.MaxValue;
            Console.WriteLine("A velocidade das estrelas é : " + velocidadeEstrelas);

            char letra = 'a' ; // Tipo char tem que estar entre aspas simples !
            Console.WriteLine("Letra : " + letra);

            string frase = "qualquer coisa xD";
            Console.WriteLine("String : " + frase);



        }



     }
}
