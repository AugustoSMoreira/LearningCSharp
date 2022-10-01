using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.OrientacaoObj;

// Abaixo temos nossa classe carro, utilizando encapsulamento e abstração
internal class Carro
{
    private int VelocidadeAtual;
    protected readonly int VelocidadeMaxima;

    public Carro(int velocidadeMaxima)
    {
        VelocidadeMaxima = velocidadeMaxima;
    }

    private int AlterarVelocidade(int delta)
    {
        VelocidadeAtual += delta;
        if (VelocidadeAtual <= 0)
        {
            VelocidadeAtual = 0;
        }
        else if (VelocidadeAtual >= VelocidadeMaxima)
        {
            VelocidadeAtual = VelocidadeMaxima;
        }
        return VelocidadeAtual;
    }

    public int Acelerar()
    {
        AlterarVelocidade(5);
        return VelocidadeAtual;
    }
    public int Frear()
    {
        AlterarVelocidade(-5);
        return VelocidadeAtual;
    }
}

// Abaixo a nossa classe Uno que herda da Classe Carro
internal class Uno : Carro
{
    public Uno() : base(160) { }
}

// Abaixo a classe Uno é instanciada com acesso aos métodos disponíveis herdada da classe carro
internal class Heranca
{
    public static void Executar()
    {
        var uno = new Uno();
        Console.WriteLine(uno.Acelerar());
        Console.WriteLine(uno.Acelerar());
        Console.WriteLine(uno.Frear());
    }
}
