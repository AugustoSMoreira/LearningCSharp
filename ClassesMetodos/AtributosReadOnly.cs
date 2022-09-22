using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.ClassesMetodos;
class Cliente
{
    public string Nome { get; set; }
    /// <summary>
    /// Esse atributo é do tipo readOnly onde ele não pode ser mutável. Apenas lido
    /// </summary>
    readonly DateTime Nascimento;// DateTime é um objeto. Será necessário instanciar quando chamar
    public Cliente(string nome, DateTime nascimento)
    {
        Nome = nome;
        Nascimento = nascimento;
    }
    public Cliente() { }
    public string GetDataDeAniversario()
    {
        return String.Format("O Cliente {0}, nasceu em {1:D2}/{2:D2}/{3}",Nome,  Nascimento.Day, Nascimento.Month, Nascimento.Year);
    }
}
internal class AtributosReadOnly
{
    public static void Executar()
    {
        var cliente = new Cliente("Carlos", new DateTime(2014, 3, 14));
        Console.WriteLine(cliente.GetDataDeAniversario());
    }
}
