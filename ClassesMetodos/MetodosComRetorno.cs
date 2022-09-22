using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.ClassesMetodos;
class CalculadoraComum
{
    public int Somar(int a, int b)
    {
        return a + b;
    }
    public int Subtrair(int a, int b)
    {
        return a - b;
    }
    public int Multiplicar(int a, int b)
    {
        return a * b;
    }
}

class CalculadoraEmCadeira
{
    int memoria;
    string palavra;

    public CalculadoraEmCadeira Somar(int a)
    {
        memoria += a;
        return this;
    }
    public CalculadoraEmCadeira Subtrair(int a)
    {
        memoria -= a;
        return this;
    }
    public CalculadoraEmCadeira ToStringfake()
    {
        palavra = memoria.ToString();
        return this;
    }
    public string Imprimir()
    {
        return palavra;
    }
}
internal class MetodosComRetorno
{
    public static void Executar()
    {
        /*var calculadora = new CalculadoraComum();
        var resultado = calculadora.Somar(5, 5);
        Console.WriteLine(resultado);

        Console.WriteLine(calculadora.Subtrair(10, 4));
        Console.WriteLine(calculadora.Multiplicar(2, 3));*/

        var calculadoraEmCadeira = new CalculadoraEmCadeira();

        var resultado = calculadoraEmCadeira.Somar(10).Subtrair(2).ToStringfake().Imprimir();

        Console.WriteLine(resultado);
    }
}
