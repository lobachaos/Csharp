namespace Csharp.ClassesEMetodos{
        class Params{
            public static void Recepcionar(params string[] pessoas){
                foreach(string pessoa in pessoas){
                    System.Console.WriteLine("Ola {0}", pessoa);
                }
            }
            public static void Executar(){
                Recepcionar("Ana" , "Bia");




            }
        }
}