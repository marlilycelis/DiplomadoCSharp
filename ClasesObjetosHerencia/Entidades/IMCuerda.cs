using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetosHerencia.Entidades
{
    public abstract class IMCuerda : InstrumentoMusical
    {
        public int CantidadCuerdas { get; protected set; }

        public void Templar()
        {
            Console.WriteLine("Templando el instrumento de cuerda");
        }
        public void CambiarCuerdas()
        {
            Console.WriteLine("Cambiando cuerdas del instrumento musical");
        }
        public override void Destruir()
        {
            Console.WriteLine("Rompiendo las cuerdas");
            base.Destruir();
        }
    }

    
}
