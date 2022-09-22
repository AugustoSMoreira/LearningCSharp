using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Fundamentos;
internal class FormatandoNumeros
{
    public static void Executar()
    {
        double valor = 15.175;
        Console.WriteLine(valor.ToString("F1")); // Output 15,2
        Console.WriteLine(valor.ToString("C")); // Output R$ 15,18. O "C" é de currency monetário.
        Console.WriteLine(valor.ToString("P")); // Output Percentual multiplicado por 100
        Console.WriteLine(valor.ToString("#.##")); // Output de formatação de design

        CultureInfo cultura = new CultureInfo("pt-BR"); // Pode usar qualquer país en-US 
        Console.WriteLine(valor.ToString("C0", cultura)); // Output R$15 sem casa decimal devido ao C0(zero)

        int inteiro = 256;
        Console.WriteLine(inteiro.ToString("D10")); //Output D10 inclui zeros a esquerda pra completar 10 números
    }
}
