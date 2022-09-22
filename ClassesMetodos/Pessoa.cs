using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.ClassesMetodos;
internal class Pessoa
{
    public string Nome;
    public int Idade;

    public string Apresentar()
    {
            return string.Format($"{Nome} tem {Idade} anos."); // Retornar com .Format dá mais opções de uso ao retorno
    }

    /*public void ApresentarNoConsole()
    {
        Console.WriteLine(Apresentar());
    }*/
}
