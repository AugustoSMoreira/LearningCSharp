using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Colecoes;
internal class QueueAula
{
    public static void Executar()
    {
        var fila = new Queue<string>(); // uso de Generic
        fila.Enqueue("Fulano");
        fila.Enqueue("Sicrano");
        fila.Enqueue("Beltrano");

        Console.WriteLine(fila.Peek());
        Console.WriteLine(fila.Count);

        Console.WriteLine(fila.Dequeue());
        Console.WriteLine(fila.Count);

        var receita = new Queue(); // Sem uso de generic

        receita.Enqueue(1);
        receita.Enqueue("ovo");
        receita.Enqueue(200);
        receita.Enqueue("gramas de farinha de trigo");

        foreach (var item in fila)
            Console.WriteLine(item);

        foreach (var item in receita)
            Console.WriteLine(item);

    }
}
