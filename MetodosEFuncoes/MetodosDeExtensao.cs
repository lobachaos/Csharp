namespace Csharp.MetodosEFuncoes{
    public static class ExtensoesInteiro{
        public static int Soma(this int num, int outroNum){
            return num + outroNum;
        }
    }



    class MetodosDeExtensao{
        public static void Executar(){
            int numero = 5;
            System.Console.WriteLine(numero.Soma(3));

        }
    }
}