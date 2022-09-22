using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Fundamentos;
internal class OperadoresAritmeticos
{
    public static void Executar()
    {
        //preço com desconto
        var preco = 1000.0;
        var imposto = 355;
        var desconto = 0.1;

        double total = preco + imposto;
        var totalComDesconto = total - (total * desconto);
        Console.WriteLine("O preço final é {0}", totalComDesconto);

        // IMC
        double peso = 91.2;
        double altura = 1.82;
        double imc = peso / Math.Pow(altura, 2); // fórmula para expoente elevado ao quadrado
        Console.WriteLine($"IMC é {Math.Round(imc)}."); // fórmula para arredondar um número

        // Número para ou ímpar
        int par = 24;
        int impar = 55;
        Console.WriteLine($"{par}/2 tem resto {par % 2}.");
        Console.WriteLine($"{impar}/2 tem resto {impar % 2}.");

    }
}
