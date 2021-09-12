namespace Csharp.EstruturasDeControle{
    class EstruturaForEach{
        public static void Executar(){
            
            var palavra = "Teste ! ";

            foreach (var letra in palavra)
            {
                System.Console.WriteLine(letra);
            }

            string[] alunos = new string[] { "Ana", "Bia","Matheus" };
            foreach (string aluno in alunos)
            {
            System.Console.WriteLine(aluno);   
            }

        }

    }
}
