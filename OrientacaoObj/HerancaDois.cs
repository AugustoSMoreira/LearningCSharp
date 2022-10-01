using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.OrientacaoObj;
class Moto
{
    private int VelocidadeAtual;
    private readonly int VelocidadeMaxima;
    protected Moto(int velocidadeMaxima)
    {
        VelocidadeMaxima = velocidadeMaxima;
    }

    protected int AlterarVelocidade(int velocidade)
    {
        VelocidadeAtual += velocidade;
        if (VelocidadeAtual >= VelocidadeMaxima)
        {
            VelocidadeAtual = VelocidadeMaxima;
        }
        else if (VelocidadeAtual <= 0)
        {
            VelocidadeAtual = 0;
        }
        return VelocidadeAtual;
    }

    public virtual int Acelerar() //@ Adicionado Modificador VIRTUAL o que significa que ele pode ser sobrescrito
                                  //pelo OVERRIDER
    {
        return AlterarVelocidade(5);
    }
    public int Frear()
    {
        return AlterarVelocidade(-5);
    }
}

class Ybr : Moto
{
    internal Ybr() : base(15) { }
}

class BigKing : Moto
{
    internal BigKing() : base(30) { }

    public override int Acelerar() // modificador override usado para alterar o método
    {
        return AlterarVelocidade(20); ;
    }
}

internal class HerancaDois
{
    public static void Executar()
    {
        var moto = new Ybr();

        Console.WriteLine(moto.Acelerar());
        Console.WriteLine(moto.Acelerar());
        Console.WriteLine(moto.Acelerar());
        Console.WriteLine(moto.Frear());

        var moto2 = new BigKing();
        Console.WriteLine(moto2.Acelerar());
        Console.WriteLine(moto2.Acelerar());
        Console.WriteLine(moto2.Acelerar());
        Console.WriteLine(moto2.Acelerar());
        Console.WriteLine(moto2.Frear());
    }
}
