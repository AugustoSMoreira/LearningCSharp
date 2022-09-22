using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.ClassesMetodos;

class Calcular
{
    // Método de Classe ou Método Estático
    public static int Somar(int a, int b)
    {
        return a + b;
    }

    // Método de Instância
    public int Subtrair(int a, int b)
    {
        return a - b;
    }
}
internal class MetodosStaticos
{
    public static void Executar()
    {
        Console.WriteLine(Calcular.Somar(3, 6));

        var instancia = new Calcular();
        Console.WriteLine(instancia.Subtrair(3, 6)); 
    }
}
