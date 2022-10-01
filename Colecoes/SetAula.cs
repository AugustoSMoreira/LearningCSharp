using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Colecoes;
internal class SetAula
{
    public static void Executar()
    {
        var livro1 = new Produto("Livro", 9.90);
        // Set não é indexado e não aceita repetição de valores.
        var cesta = new HashSet<Produto> { livro1, new Produto("Livro1", 19.90), new Produto("Livro2", 21.90) };

        var carrinho = new HashSet<Produto> { };
        //carrinho.AddRange(cesta);
        //carrinho.RemoveAt(0);

        foreach (var c in carrinho)
        {
            //Console.Write(carrinho.IndexOf(c));
            Console.WriteLine($" {c.Titulo} {c.Preco}");
        }
    }
}
