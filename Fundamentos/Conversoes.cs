namespace Csharp.Fundamentos {
    class Conversoes{
        public static void Executar(){
            // nao tem perda de informação
            int inteiro = 20;
            double quebrada = inteiro;

            System.Console.WriteLine(quebrada);

            // tem perda de informação
            // e precisa do cast
            double nota = 5.5;
            int notaTruncada = (int) nota;
            System.Console.WriteLine("Nota truncada :{0} ",notaTruncada);

            // String --> Inteiro formas não seguras , pode dar erro ! 

            System.Console.WriteLine("Insira sua idade : ");
            string idade = System.Console.ReadLine();
            int idadeInteiro = int.Parse(idade);

            idadeInteiro= System.Convert.ToInt32(idade);
            System.Console.WriteLine("Idade informada : {0}", idadeInteiro);
            
            // String --> Inteiro forma segura

            System.Console.WriteLine("Informe um número : ");
            string valor = System.Console.ReadLine();
            int num ;
            int.TryParse(valor , out num);

            System.Console.WriteLine("Numéro digitado : {0} ",num);



        }




    }





}