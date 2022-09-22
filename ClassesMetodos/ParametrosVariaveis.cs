using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.ClassesMetodos;
internal class ParametrosVariaveis
{
    public static void Recepcionar(params string[] pessoas)
    {
        foreach (var pessoa in pessoas)
        {
            Console.WriteLine($"Olá {pessoa}");
        }
    }
    public static void Executar()
    {
        Recepcionar("Carlos", "Enzo", "Jeniffer", "Hulk");
    }
}
