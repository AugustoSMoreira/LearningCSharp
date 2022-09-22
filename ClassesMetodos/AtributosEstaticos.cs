using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.ClassesMetodos;

class Produto
{
    public string Nome;
    public double Preco;
    public static double Desconto;

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }
    public Produto()
    {

    }

    public double DescontoProduto()
    {
        var culture = new CultureInfo("pt-BR");
        var desc = Preco - Preco * Desconto;
        desc.ToString("C", culture);
        return desc;
    }
}
internal class AtributosEstaticos
{
    public static void Executar()
    {
        var produto = new Produto();
        produto.Nome = "PS5";
        produto.Preco = 5.000;

        Produto.Desconto = 0.1;

        

        Console.WriteLine($"O {produto.Nome} custa {produto.Preco} e com desconto fica {produto.DescontoProduto()}");
    }
}
