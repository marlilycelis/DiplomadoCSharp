using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYO_Cajero
{
    public class Cuenta
    {
        /* Se definen 2 campos (atributos) para la clase */
        protected string titular;
        protected float cantidad;

        public Cuenta(string titular, float cantidad = 0)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string getTitular()
        {
            return this.titular;
        }

        public float getSaldo()
        {
            return this.cantidad;
        }

        /* Método que permite agregar saldo a una cuenta. 
         * Recibe un numeros decimal de tipo flotante. 
         * Retorna un String */
        public string Ingresar(float cantidadRecibida)
        {
            if(cantidadRecibida < 0)
            {
                return "Que pena, la cantidad es negativa, no puedo hacer nada";
            }
            else
            {
                this.cantidad = this.cantidad + cantidadRecibida;
                return "La cantidad fue agregada, el nuevo total es " + this.cantidad;
            }
        }

        /* Función para disminuir el saldo de una cuenta.
         * IN: float cantidadARetirar
         * OUT: String
         * */
        public string Retirar(float cantidadARetirar)
        {
            float subtotal = this.cantidad - cantidadARetirar;
            if(subtotal < 0)
            {
                string mensaje = "No tienes todo ese dinero, solo te daré " + this.cantidad;
                this.cantidad = 0;
                return mensaje;
            }
            else
            {
                this.cantidad = subtotal;
                return "Usted ha retirado " + cantidadARetirar + ". El saldo restante es " + subtotal;
            }
        }
    }
}
