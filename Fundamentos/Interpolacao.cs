namespace Csharp.Fundamentos 
{
    class Interpolacao
    {
        public static void Executar()
        {
        string marca = "Dell" ;
        string nome = "PC All In One";
        double preco = 5000.99;
            
        // acc interpolacao entre chaves.   
         System.Console.WriteLine("O {0} da marca {1} custa {2} reais" ,nome,marca,preco);

         // resolvendo variaveis dentro da String
         System.Console.WriteLine($"O {nome} é da marca {marca}");

        }

    }
}