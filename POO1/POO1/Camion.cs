using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO1;

internal class Camion : Vehiculo
{
    private int cargaActual;

    public Camion(int anio, string elColor, string elModelo, int carga) : base(anio, elColor, elModelo)
    {
        cargaActual = carga;
    }

    public override void acelerar(int cuanto)
    {
        base.acelerar(cuanto - 5);
        Console.WriteLine("El camión acelera más lento debido a la carga.");
    }

    public override void InformacionVehiculo()
    {
        base.InformacionVehiculo();
        Console.WriteLine($"Carga actual: {cargaActual}kg");
        Console.WriteLine("----------------------------");
    }
}
