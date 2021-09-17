using System;
namespace Csharp.MetodosEFuncoes{
    delegate double Soma(double a , double b);
    delegate void ImprimirSomar(double a , double b);

    class UsandoDelegate{
    static double MinhaSoma(double a , double b){
        return a + b;
    }
    static void MeuImprimirSomar(double a , double b){
        Console.WriteLine(a+b);
    }

        public static void Executar(){
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2,3));
            ImprimirSomar op2 = MeuImprimirSomar;
            op2(4,5);

            Func <double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(10,10));

            Action< double ,double > op4 = MeuImprimirSomar;
            op4(20,20);

        }
    }
}