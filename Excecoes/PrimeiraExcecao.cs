using System;
namespace Csharp.Excecoes{
    public class Conta{
        private double Saldo;

        public Conta(double saldo){
            Saldo = saldo;
        }
        public void Sacar(double valor){
            if(valor > Saldo){
                throw new ArgumentException("Saldo insuficiente");
            }
            Saldo -= valor;
        }
    }
    class PrimeiraExcecao{
        public static void Executar(){
            var conta = new Conta(1234.45);
            try {
                conta.Sacar(2234);
                System.Console.WriteLine("Retirado com Sucesso !");
            }catch (Exception ex){
                System.Console.WriteLine(ex.Message);
            } finally {
                System.Console.WriteLine("Thanks!");
            }

        }
    }
}