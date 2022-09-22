using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.EstruturaDeControle;
internal class Foreach
{
    public static void Executar()
    {
        var palavra = "Opa";

        foreach (var item in palavra)
        {
            Console.WriteLine(item);
        }

        var alunos = new string[] { "Ana", "Bia", "Carlos" }; // Array de strings
        foreach (var item in alunos)
        {
            Console.WriteLine(item);
        }
    }
}
