using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.ClassesMetodos;
internal class DesafioAcessarAtributo
{
    int a = 10;
    public static void Executar()
    {
        var desafio = new DesafioAcessarAtributo();
        Console.WriteLine(desafio.a);
    }
}
