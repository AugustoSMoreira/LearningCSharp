using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Fundamentos;
internal class OperadoresLogicos
{
    public static void Executar()
    {
        var executouTrabalho1 = true;
        var executouTrabalho2 = false;

        var comprouTv50 = executouTrabalho1 && executouTrabalho2;
        Console.WriteLine($"Comprou a Tv 50? {comprouTv50}");

        var comprouSorvete = executouTrabalho1 || executouTrabalho2;
        Console.WriteLine($"Comprou sorverte? {comprouSorvete}");

        var comprouPS5 = executouTrabalho1 ^ executouTrabalho2; // Exclusivo
        Console.WriteLine($"Comprou PS5? {comprouPS5}");

        Console.WriteLine($"Mais saudável? {!comprouSorvete}"); // Negação
    }
}
