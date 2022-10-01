using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Colecoes;
internal class Igualdade
{
    public static void Executar()
    {
        var p1 = new Produto("Produto", 10.0 );
        var p2 = new Produto("Produto", 10.0 );
        var p3 = p2;
        Console.WriteLine(p1 == p2); // output é false. Pq fazem referências em lugares de memória diferentes

        Console.WriteLine(p2 == p3); // output é True. Pois aponta para o msm lugar de memória.

        Console.WriteLine(p1.Equals(p2)); // output é false. Pois compara endereço de memória.
    }
}
