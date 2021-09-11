namespace Csharp.Fundamentos {
    class FormatandoNumeros{
        public static void Executar(){
            double valor = 15.754;
            System.Console.WriteLine(valor.ToString("F1"));
            System.Console.WriteLine(valor.ToString("C")); // pega a moeda local do sistema
            System.Console.WriteLine(valor.ToString("P"));
            System.Console.WriteLine(valor.ToString("#.##")); // poderia ser F2
            System.Console.WriteLine(valor.ToString("#.###")); 
            
            int inteiro = 210;
            System.Console.WriteLine(inteiro.ToString("D10"));
        }



    }

}
