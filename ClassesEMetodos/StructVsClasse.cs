namespace Csharp.ClassesEMetodos{
    
    public struct SPonto{
        public int X;
        public int Y;

    }

    public class  CPonto{
        public int X;
        public int Y;
    }
    
    class StructVsClasse{
        public static void Executar(){

            SPonto ponto1 = new SPonto { X = 1 , Y = 3};
            SPonto copiaPonto1 = ponto1;
            ponto1.X = 2;

            System.Console.WriteLine($"Ponto 1 X = {ponto1.X}" );
            System.Console.WriteLine("Copia Ponto 1 = " + copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 2 , Y = 5};
            CPonto copiaPonto2 = ponto2;
            ponto2.X = 10;
            System.Console.WriteLine("Ponto 2 X = {0}", ponto2.X);
            System.Console.WriteLine("Copia Ponto 2 = {0}",copiaPonto2.X);
        }
    }
}