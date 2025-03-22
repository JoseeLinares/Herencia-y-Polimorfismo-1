
using POO1;
using System;

namespace p1bpoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var moto = new Motocicleta1(2022, "Negra", "Harley Davidson", 1200, true);
            moto.acelerar(40);
            moto.Encender();
            moto.InformacionVehiculo();

            var camion = new Camion(2020, "Azul", "Volvo", 5000);
            camion.acelerar(10);
            camion.InformacionVehiculo();

            var autoCombustion = new AutoDeCombustion(2023, "Rojo", "Toyota", 49);
            autoCombustion.acelerar(30);
            autoCombustion.Frenar();
            autoCombustion.InformacionVehiculo();

            var carroElectrico = new CarroElectrico(2025, "Blanco", "Tesla", 49);
            carroElectrico.acelerar(10);
            carroElectrico.InformacionVehiculo();
        }
    }

}
