using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetosHerencia.Entidades
{
    public abstract class InstrumentoMusical
    {
        //------PROPIEDADES------
        public string MaterialBase { get; protected set; }
        public string Color { get; set; }
        public float TamanioMtrs { get; protected set; }
        public string Forma { get; protected set; }
        public string Serial { get; protected set; }

        //------MÉTODOS O FUNCIONES------
        public virtual void Destruir()
        {
            Console.WriteLine("Le voy a prender fuego al IM");
        }

    }
}
