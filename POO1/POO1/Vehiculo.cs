using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }
        private int velocidad = 0;

        public Vehiculo(int anio, string elColor, string elModelo)
        {
            Year = anio;
            Color = elColor;
            Modelo = elModelo;
        }

        public virtual void InformacionVehiculo()
        {
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Year}");
            Console.WriteLine($"Vas a {velocidad} KMS / Hora");
            Console.WriteLine("----------------------------");
        }

        public virtual void acelerar(int cuanto)
        {
            velocidad += cuanto;
        }

        public virtual void Frenar()
        {
            velocidad -= 10;
            Console.WriteLine($"El vehículo frenó. Velocidad actual: {velocidad} KMS/Hora");
        }
    }


}
