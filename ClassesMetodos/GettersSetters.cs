using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.ClassesMetodos;
public class Moto
{
    private string Fabricante;
    private string Modelo;
    private int Cilindrada;

    public Moto(string fabricante, string modelo, int cilindrada)
    {
        /* Fabricante = fabricante;
         Modelo = modelo;
         Cilindrada = cilindrada;*/
        SetFabricante(Fabricante);
        SetModelo(Modelo);
        SetCilindrada(Cilindrada);
    }

    public Moto()
    {

    }

    public string GetFabricante()
    {
        return Fabricante;
    }
    public void SetFabricante(string fabricante)
    {
        Fabricante = fabricante;
    }

    public string GetModelo()
    {
        return Modelo;
    }
    public void SetModelo(string modelo)
    {
        Modelo = modelo;
    }

    public int GetCilindrada()
    {
        return Cilindrada;
    }
    public void SetCilindrada(int cilindrada)
    {
        /* if (cilindrada > 0)
             Cilindrada = cilindrada;*/
        Cilindrada = Math.Abs(cilindrada);
    }
}
internal class GettersSetters
{
    public static void Executar()
    {
        var moto = new Moto();
        moto.SetFabricante("Yamaha");
        moto.SetModelo("YBR");
        moto.SetCilindrada(-150);

        Console.WriteLine("A fabricante {0} criou a {1} de {2} cilindradas"
            , moto.GetFabricante(), moto.GetModelo(), moto.GetCilindrada());
    }
}
