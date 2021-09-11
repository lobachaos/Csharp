namespace Csharp.Fundamentos 
{
    class Inferencia 
    {
        public static void Executar()
        {
            var nome = "Joao" ; // substitui var por string automaticamente 
            // inferencias devem ser inicializadas !
            System.Console.WriteLine("Nome armazenado : " + nome);


            var idade = 32;
            System.Console.WriteLine("Idade armazenada : " + idade);

            int a ;
            a = 3;
            System.Console.WriteLine(a); 
        }
    }

}