using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Colecoes;
internal class ArrayListAula
{
    public static void Executar()
    {
        var arraylist = new ArrayList
        {
            "Palavra",
            123456,
            10.00,
            true
        };

        arraylist.Add("outra palavra");

        foreach (var item in arraylist)
            Console.WriteLine($"{item} => {item.GetType()}");
    }
}
