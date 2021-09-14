namespace Csharp.ClassesEMetodos{
        class ParametrosPorReferencia{
            public static void AlterarRef(ref int numero){
                numero = numero + 300;

            }
            public static void AlterarOut(out int numero){
                // com out precisa ser inicilizado
                numero = 0;
                numero = numero + 5;
            }
        public static void Executar(){

            int a = 2;
            AlterarRef(ref a);
            System.Console.WriteLine(a);

            int b ;
            AlterarOut(out b);
            System.Console.WriteLine(b);


        }
    }
}