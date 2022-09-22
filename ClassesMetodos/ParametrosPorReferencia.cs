using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.ClassesMetodos;
internal class ParametrosPorReferencia
{
    public static void AlterarRef(ref int numero) // passa o número por referência
    {
        numero += 1000;
    }
    public static void AlterarOut(out int numero) // Não recebe valor
    {
        numero = 0;
        numero += 800;
    }
    public static void Executar()
    {
        int a = 5;
        AlterarRef(ref a);
        Console.WriteLine(a);

        AlterarOut(out int b);
        Console.WriteLine(b);
    }
}
