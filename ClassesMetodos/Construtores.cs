using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.ClassesMetodos;

class Carro
{
    public Carro(string fabricante, string modelo, int ano)
    {
        Fabricante = fabricante;
        Modelo = modelo;
        Ano = ano;
    }
    public Carro()
    {

    }
    public string Fabricante;
    public string Modelo;
    public int Ano;
}
internal class Construtores
{
    public static void Executar()
    {
        var carro1 = new Carro();
        carro1.Fabricante = "BMW";
        carro1.Modelo = "325i";
        carro1.Ano = 2017;
        Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano} ");

        Console.Write("Qual o fabricante do carro?  ");
        var fabricante = Console.ReadLine();
        Console.Write("Qual o Modelo?  ");
        var modelo = Console.ReadLine();
        Console.Write("Qual o ano?  ");
        int.TryParse(Console.ReadLine(), out var ano);

        var carro2 = new Carro(fabricante, modelo, ano);
        Console.WriteLine($"O Fabricante é {carro2.Fabricante} o modelo é {carro2.Modelo} e o ano é {carro2.Ano}");

        var carro3 = new Carro()
        {
            Fabricante = "Ferrai",
            Modelo = "Spider",
            Ano = 2020
        };
    }
}
