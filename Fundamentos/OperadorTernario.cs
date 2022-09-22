using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Fundamentos;
internal class OperadorTernario // Ternário de 3 partes
{
    public static void Executar()
    {
        // expressão ? true : false

        var nota = 7.0;

        string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";

        Console.WriteLine(resultado);
    }
}
