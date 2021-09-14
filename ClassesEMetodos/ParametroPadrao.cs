namespace Csharp.ClassesEMetodos{
    class ParametroPadrao{
        public static int Somar(int a = 1 , int b = 1){
            return a+b;
        }
        public static void Executar(){
            System.Console.WriteLine(Somar(b: 10));
            System.Console.WriteLine( "Valor Padrao --> " + Somar());
            System.Console.WriteLine(Somar(3,3));
            System.Console.WriteLine(Somar(a : 4, b: 4));




        }
    }
}