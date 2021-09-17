using System;
namespace Csharp.MetodosEFuncoes{
    class ExpressoesLambda{
        public static void Executar(){
            Action algoNoConsole = () => {
                Console.WriteLine("Lambda com C# ! ");
            };

            algoNoConsole();

            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            System.Console.WriteLine(jogarDado());

            Func<int,string> conversorHex = numero => {
                return numero.ToString("X");
            };

            System.Console.WriteLine(conversorHex(123));

            Func<int,int,int,string> formatarData = (dia,mes,ano) => 
            String.Format("{0:D2}/{1:D2}/{2:D4}", dia,mes,ano);

            System.Console.WriteLine(formatarData(1,1,2020));

        }
    }
}