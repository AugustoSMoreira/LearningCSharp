using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.ClassesMetodos;
internal class ParametroPadrao
{
    public static int Somar(int a = 1, int b =2)
    {
        return a + b;
    }
    public static void Executar()
    {
        Console.WriteLine(Somar(30, 20)); 
        Console.WriteLine(Somar(30)); 
        Console.WriteLine(Somar(b: 3)); 
    }
}
