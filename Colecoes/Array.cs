namespace Csharp.Colecoes{
    class Array{
        public static void Executar(){
            string[] alunos = new string[5];
            alunos[0] = "André";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Diego";
            alunos[4] = "Eduardo";

            foreach(string aluno in alunos){
                System.Console.WriteLine(aluno);
            }

            double soma = 0.0;
            double[] notas = {8.0 , 7.5 , 9.0 , 5.5 , 6.0};

            foreach(int num in notas) {
            soma += num;

            }

            double media = soma / notas.Length;
            System.Console.WriteLine(soma);

            char[] letras = {'A','r','r','a','y'};
            string palavra = new string(letras);
            System.Console.WriteLine(palavra);

        }

    }

}