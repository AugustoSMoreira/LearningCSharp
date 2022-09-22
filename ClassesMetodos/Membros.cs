using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.ClassesMetodos;
internal class Membros
{
    public static void Executar()
    {
        Pessoa sicrano = new Pessoa();

        sicrano.Nome = "Carlos";
        sicrano.Idade = 41;

        var dadosDoSicrano = sicrano.Apresentar();

        Console.WriteLine(dadosDoSicrano);
    }
}
