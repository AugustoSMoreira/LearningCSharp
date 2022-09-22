using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.ClassesMetodos;
public class CarroOpcional
{
    double desconto = 0.1;

    string nome;
    public string Nome
    {
        get
        {
            return "Opcional: " + nome;
        }
        set
        {
            nome = value;
        }
    }

    // Propriedade autoimplementada
    public double Preco { get; set; }

    // Somente Leitura
    public double PrecoComDesconto // sem atribuição
    {
        get => Preco - (desconto * Preco); // implicitamente há um return
    }

    public CarroOpcional()
    {

    }
    public CarroOpcional(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

}
internal class Propriedades
{
    public static void Executar()
    {
        var carro1 = new CarroOpcional("Ar condicionado", 3499.9);
        Console.WriteLine(carro1.PrecoComDesconto);
    }
}
