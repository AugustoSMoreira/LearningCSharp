using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Fundamentos;
internal class Conversoes
{
    public static void Executar()
    {
        int inteiro = 10;
        double quebrado = inteiro;
        Console.WriteLine(quebrado);

        double nota = 9.7;
        int notaTruncada = (int)nota; // a conversão é chamada de Casting
        Console.WriteLine("Nota truncada: {0}", notaTruncada);

        Console.Write("Digite sua idade: ");
        string idadeString = Console.ReadLine();
        int idade = int.Parse(idadeString);
        Console.WriteLine("idade inserida: {0}", idade);

        idade = Convert.ToInt32(idadeString);
        Console.WriteLine("Resultado: {0}", idade);

        Console.WriteLine("Digite o primeiro número");
        string palavra = Console.ReadLine();
        //int numero; Podemos declarar a variável fora do TryParse tbm
        int.TryParse(palavra, out int numero); // O TryParse tenta fazer um parse se não conseguir retorna zero
        Console.WriteLine("Esse foi o número: {0}", numero);

        Console.WriteLine("Digite o segundo número");
        int.TryParse(Console.ReadLine(), out int numero2); // Outra forma de usar o TryParse
        Console.WriteLine("Esse foi o número: {0}", numero2);

    }
}
