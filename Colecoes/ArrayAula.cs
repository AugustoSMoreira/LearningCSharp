using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Colecoes;
internal class ArrayAula
{
    public static void Executar()
    {
        string[] palavras =  { "Carlos", "Enzo", "Jeniffer" };
        string[] palavrasDois = new string[3];
        palavrasDois[0] = "Augusto";
        palavras[0] = "Brad";

        foreach (string palavra in palavras)
            Console.WriteLine(palavra);

        int[] numeros = { 1, 2, 3, 4, 5, 6, };
        var numerosDois = new int[3];
        numerosDois[0] = numeros[0];
        numerosDois[1] = numeros[1];
        numerosDois[2] = numeros[2];

        foreach (int numero in numerosDois)
            Console.WriteLine(numero);

    }
}
