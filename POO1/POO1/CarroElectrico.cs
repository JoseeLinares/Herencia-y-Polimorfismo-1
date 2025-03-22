using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class CarroElectrico : Vehiculo
    {
        private int nivelBateria;

        public CarroElectrico(int anio, string elColor, string elModelo, int bateria) : base(anio, elColor, elModelo)
        {
            nivelBateria = bateria;
        }

        public override void InformacionVehiculo()
        {
            base.InformacionVehiculo();
            Console.WriteLine($"Nivel de batería: {nivelBateria}%");
            Console.WriteLine("----------------------------");
        }
    }

}
