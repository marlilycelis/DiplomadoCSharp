using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazVehiculos.Interfaz
{
    interface IVehiculo
    {
        void encender();
        void apagar();
        void acelerar();
        void frenar();
    }
}
