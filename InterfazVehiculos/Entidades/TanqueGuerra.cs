using InterfazVehiculos.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazVehiculos.Entidades
{
    class TanqueGuerra : IVehiculo,IArmaFuego
    {
        public int CantidadRuedas { get; protected set; }
        public int PotenciaFuego { get; set; }
        public float VelocidadMaximaKm_H { get; set; }
        public float CapacidadMaximaCargaToneladas { get; set; }
        public bool ManejoControlRemoto { get; set; }
        public void acelerar()
        {
            Console.WriteLine("Estoy acelarando");
        }

        public void apagar()
        {
            Console.WriteLine("Tanque Apagado");
        }

        public void Cargar()
        {
            Console.WriteLine("Arma Cargada lista para disparar");
        }

        public void Disparar()
        {
            Console.WriteLine("Disparar PUM - PUM - PUM");
        }

        public void encender()
        {
            Console.WriteLine("Estoy encendida");
        }

        public void frenar()
        {
            Console.WriteLine("Estoy desacelarando");
        }
    }
}
       
