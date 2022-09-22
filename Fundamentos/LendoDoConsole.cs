using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Fundamentos;
internal class LendoDoConsole
{
    public static void Executar()
    {
        Console.Write("Digite seu futuro salário:  ");
        var salario = double.Parse(Console.ReadLine(),
            CultureInfo.InvariantCulture); // CultureInfo.InvariantCulture serve para o sistema utlizar os recursos de pontos do sistema do usuário.
        Console.WriteLine($"Seu salário futuro será maior que {salario}");
    }
}
