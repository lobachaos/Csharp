namespace Csharp.Colecoes{
    class Igualdade{
        public static void Executar(){
            Produto p1 = new Produto("Caneta", 2.57);
            Produto p3 = new Produto("Caneta", 2.57);
            

            System.Console.WriteLine(p1 == p3);
            System.Console.WriteLine(p1.Equals(p3));

        }
    }
}