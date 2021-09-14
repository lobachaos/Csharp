namespace Csharp.ClassesEMetodos{
    class DesafioAcessarAtributo{

        int a = 10;
        public static void Executar(){  
            // acessar variavel 'a' dentro do metodo executar 
            DesafioAcessarAtributo df = new DesafioAcessarAtributo();
            System.Console.WriteLine(df.a);

        }

    }
}