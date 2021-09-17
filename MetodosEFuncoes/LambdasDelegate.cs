namespace Csharp.MetodosEFuncoes{
    delegate double Operacao(double x, double y);
    class LambdasDelegate{
        public static void Executar(){
            Operacao sum = (x,y) => x + y;
            Operacao sub = (x,y) => x - y;
            Operacao mult = (x,y) => x * y;

            System.Console.WriteLine(sum(2,2));
            System.Console.WriteLine(sub(2,2));
            System.Console.WriteLine(mult(2,2));
        }
    }
}