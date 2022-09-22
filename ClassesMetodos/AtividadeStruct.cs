using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.ClassesMetodos;
interface Ponto
{
    void MoverNaDiagonal(int delta); // Função publica sem corpo
}

struct Coordenada : Ponto
{
    public int X;
    public int Y;

    public Coordenada(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void MoverNaDiagonal(int delta)
    {
        X += delta;
        Y += delta;
    }
}
internal class AtividadeStruct
{
    public static void Executar()
    {
        Coordenada coordenadaInicial;
        coordenadaInicial.X = 2;
        coordenadaInicial.Y = 2;

        Console.WriteLine("Coordenada Inicial:");
        Console.WriteLine($"X = {coordenadaInicial.X} Y = {coordenadaInicial.Y}");

        var coordenadaFinal = new Coordenada(4, 4);
        coordenadaFinal.MoverNaDiagonal(10);

        Console.WriteLine("Coordenada Final:");
        Console.WriteLine($"X = {coordenadaFinal.X} Y = {coordenadaFinal.Y}");
    }
}
