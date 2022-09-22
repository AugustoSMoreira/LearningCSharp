using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.ClassesMetodos;
public enum Genero { Acao, Terror, Ficcao, Romance, Comedia }
public class Filme
{
    public string Titulo { get; set; }
    public Genero Genero { get; set; }

    public void GetFilme()
    {
        Console.WriteLine($"O filme {Titulo} é do gênero {Genero}");
    }
}
internal class Enums
{
    public static void Executar()
    {
        var filme = new Filme();
        filme.Titulo = "Matrix";
        filme.Genero = Genero.Ficcao;

        filme.GetFilme();
    }
}
