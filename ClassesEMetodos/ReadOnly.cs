using System;

namespace Csharp.ClassesEMetodos{
    public class Cliente{
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome , DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string getNascimento() {
            return string.Format("{0}/{1}/{2}",Nascimento.Day , Nascimento.Month,Nascimento.Year);
        }
    }
    class ReadOnly{
        public static void Executar(){
            var cliente = new Cliente("Joaozim", new DateTime(2000,05,09));
            System.Console.WriteLine(cliente.Nome + " " +  cliente.getNascimento());
        }
    }
}