namespace Csharp.ClassesEMetodos{
    public class CarroOpcional{
        string nome;
        double preco;
        public string Nome{
            get{return "Opcional" + nome;}
            set{nome = value;}
        }

        // Propriedades auto implementada
        public double Preco{ get ; set ; }


    }
    class Props{
        public static void Executar(){

            var cp = new CarroOpcional();
            cp.Nome = " Ar";
            System.Console.WriteLine(cp.Nome);
        }
    }
}