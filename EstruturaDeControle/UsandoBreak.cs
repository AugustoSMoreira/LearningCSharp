using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.EstruturaDeControle;
internal class UsandoBreak
{
    public static void Executar()
    {
        Random random = new Random();
        var numero = random.Next(1, 51);
        Console.WriteLine($"O numero que queremos é {numero}");

        for (int i = 0; i <= numero; i++)
        {
            Console.Write($"{i} é o numero que queremos?  ");
            if (numero == i)
            {
                Console.WriteLine($"SIM!!");
                break;
            }
            else
            {
                Console.WriteLine($"NÃO!!");
            }
        }
        Console.WriteLine("Fim!");
    }
}
