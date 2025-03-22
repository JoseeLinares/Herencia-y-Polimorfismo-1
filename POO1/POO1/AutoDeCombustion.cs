using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO1;

internal class AutoDeCombustion : Vehiculo
{
    private int combustibleRestante;

    public AutoDeCombustion(int anio, string elColor, string elModelo, int combustible) : base(anio, elColor, elModelo)
    {
        combustibleRestante = combustible;
    }

    public override void InformacionVehiculo()
    {
        base.InformacionVehiculo();
        Console.WriteLine($"Combustible restante: {combustibleRestante}%");
        Console.WriteLine("----------------------------");
    }

    public override void Frenar()
    {
        base.Frenar();
        Console.WriteLine("El auto de combustión está frenando.");
    }
}