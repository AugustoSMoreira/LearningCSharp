using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.ClassesMetodos;
struct SPonto
{
    public int X;
    public int Y;
}
class CPonto
{
    public int X;
    public int Y;
}
internal class ClassVsStruct
{
    public static void Executar()
    {
        SPonto sPonto = new SPonto { X = 2, Y = 2 }; // Tipo Struct
        SPonto copiaSPonto = sPonto; // Atribuição por VALOR!!! Os valores são independentes
        sPonto.X = 5;

        Console.WriteLine($"Struct X começa com 2 e recebe sPonto X = {sPonto.X}");
        Console.WriteLine($"copiaSPonto X = {copiaSPonto.X}");

        CPonto cPonto = new CPonto { X = 4, Y = 4 }; // Tipo Class
        CPonto copiaCPonto = cPonto; // Atribuição por REFERÊNCIA!!! Aponta para o msm espaço na memória
        cPonto.X = 10;

        Console.WriteLine($"Class X começa com 4 e recebe cPonto X = {cPonto.X}");
        Console.WriteLine($"copiaCPonto X = {copiaCPonto.X}");
    }
}
