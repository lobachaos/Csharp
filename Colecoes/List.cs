using System;
using System.Collections.Generic;
namespace Csharp.Colecoes{
    public class Produto{
        string Nome;
        double Preco;
        
        public Produto(string nome, double preco){
            Nome = nome;
            Preco = preco;
            
        }

        public override bool Equals(object obj)
        {
            return obj is Produto produto &&
                   Nome == produto.Nome && Preco == produto.Preco;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome);
        }
    }
    class List{
        public static void Executar(){
            var livro = new Produto("HP", 49.99);
            
            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>(){
                new Produto("Camisa",20),
                new Produto("Conjunto Cartas", 50.50),
                new Produto("Canudo", 1.60)
            };

            carrinho.AddRange(combo);

            System.Console.WriteLine(carrinho.Count);
        }
    }
}