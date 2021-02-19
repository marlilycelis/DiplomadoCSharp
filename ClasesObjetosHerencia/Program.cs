using ClasesObjetosHerencia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetosHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*InstrumentoMusical instrumentoMusical = new InstrumentoMusical();
            instrumentoMusical.Color = "Canela";
            instrumentoMusical.Destruir();*/

            /*IMCuerda iMCuerda = new IMCuerda();
            iMCuerda.CambiarCuerdas();
            iMCuerda.Templar();
            iMCuerda.Color = "Verde";
            iMCuerda.Destruir();*/

            IMCGuitarra iMCGuitarra = new IMCGuitarra();
            iMCGuitarra.Color = "Azul";
            iMCGuitarra.CambiarCuerdas();
            iMCGuitarra.Templar();
            iMCGuitarra.Destruir();

            Console.ReadKey();
        }
    }
}
