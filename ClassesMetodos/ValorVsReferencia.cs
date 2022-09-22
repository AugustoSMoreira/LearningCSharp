using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.ClassesMetodos;
public class Dependentes
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}
internal class ValorVsReferencia
{
    public static void Executar()
    {
        var dep = new Dependentes();
        dep.Idade = 21;
        dep.Nome = "Carlos";

        var copiadep = dep;

        Console.WriteLine($"original: {copiadep.Idade} cópia: {dep.Idade}");
        Console.WriteLine($"original: {copiadep.Nome} cópia: {dep.Nome}");

        copiadep.Nome = "Enzo"; // Mesmo alterando a cópia, altera tbm o original. Por ser referência.

        Console.WriteLine($"original: {dep.Nome} cópia: {copiadep.Nome}");
    }
}
