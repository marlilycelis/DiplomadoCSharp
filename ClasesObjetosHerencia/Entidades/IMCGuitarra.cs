
using ClasesObjetosHerencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetosHerencia.Entidades
{
    class IMCGuitarra : IMCuerda, IInstrumentoMusical
    {
        public int Diapasones { get; protected set; }

        public void Armar()
        {
            Console.WriteLine("Colocar las cuerdas");
            Console.WriteLine("Ajustar las cuerdas");
        }
        public void ProducirSonido()
        {
            Console.WriteLine("Guitarra produciendo sonido al rasgar las cuerdas");
        }
        public override void Destruir()
        {
            base.Destruir();
            Console.WriteLine("Golpeala fuere contra la pared");
        }
    }
}
