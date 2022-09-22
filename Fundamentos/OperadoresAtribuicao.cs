using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Fundamentos;
internal class OperadoresAtribuicao
{
    public static void Executar()
    {
        var num1 = 3;
        num1 = 7; // aqui substituímos o valor
        num1 += 10; // num1 = num1 + 10 aqui acrescenta o valor 10 mais o que já tinha
        num1 -= 10; // num1 = num1 - 10 
        num1 *= 3;
        num1 /= 3;
        Console.WriteLine(num1);
    }
}
