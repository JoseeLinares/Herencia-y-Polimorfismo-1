using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Motocicleta1 : Vehiculo
    {
        private bool tieneCasco;
        private int cilindraje;
        private bool encendida;

        public Motocicleta1(int anio, string elColor, string elModelo, int cilindraje, bool casco) : base(anio, elColor, elModelo)
        {
            this.cilindraje = cilindraje;
            tieneCasco = casco;
            encendida = false;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto + 5);
            Console.WriteLine("La motocicleta acelera más rápido!");
        }

        public void Encender()
        {
            encendida = true;
            Console.WriteLine("Motocicleta encendida");
        }

        public override void InformacionVehiculo()
        {
            base.InformacionVehiculo();
            Console.WriteLine($"Cilindraje: {cilindraje}cc");
            Console.WriteLine($"Tiene casco: {(tieneCasco ? "Sí" : "No")}");
            Console.WriteLine($"Encendida: {(encendida ? "Sí" : "No")}");
            Console.WriteLine("----------------------------");
        }
    }
}
