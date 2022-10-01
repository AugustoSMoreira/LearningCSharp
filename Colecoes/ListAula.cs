using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Colecoes;
public class Produto
{
    public Produto(string titulo, double preco)
    {
        Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
        Preco = preco;
    }

    public string Titulo { get; set; }
    public double Preco { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is Produto produto &&
               Titulo == produto.Titulo &&
               Preco == produto.Preco;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Titulo, Preco);
    }
}
internal class ListAula
{
    public static void Executar()
    {
        var livro1 = new Produto("Livro", 9.90);

        var cesta = new List<Produto> { livro1, new Produto("Livro1", 19.90), new Produto("Livro2", 21.90) };

        var carrinho = new List<Produto> { };
        carrinho.AddRange(cesta);
        carrinho.RemoveAt(0);

        foreach (var c in carrinho)
        {
            Console.Write(carrinho.IndexOf(c));
            Console.WriteLine($" {c.Titulo} {c.Preco}");
        }
    }
}
