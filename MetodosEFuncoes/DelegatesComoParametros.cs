using System;
namespace Csharp.MetodosEFuncoes{
    class DelegatesComoParametros{

        public delegate int Operacao(int x , int y);
        public static int Somar (int x , int y){
            return x + y ;
        }
        public static string Calculadora (Operacao op , int x , int y){
            var resultado = op(x, y);
            return "Resultado : " + resultado;
        }


        public static void Executar(){
            Operacao sub = (int x, int y) => x - y;

            System.Console.WriteLine(Calculadora(sub,3,2));
            System.Console.WriteLine(Calculadora(Somar,1,1));
        }
    }
}