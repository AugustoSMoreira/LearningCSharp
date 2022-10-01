using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Colecoes;
internal class DictionaryAula
{
    public static void Executar()
    {
        // em Dictionary a chave não aceita repetição e o valor aceita <key, value>
        var filmes = new Dictionary<int, string>
        {
            { int.Parse(Console.ReadLine()), Console.ReadLine() }
        };

        foreach (var f in filmes)
            Console.WriteLine($"{f.Value} é de {f.Key}");
    }
}
