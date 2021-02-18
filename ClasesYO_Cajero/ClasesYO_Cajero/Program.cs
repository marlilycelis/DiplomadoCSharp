using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYO_Cajero
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Programa que permite agregar cuentas y hacer transacciones con ella
             Tarea
            */

            List<Cuenta> cuentas = new List<Cuenta>();
            Cuenta comodin;
            float aRetirar, aConsignar;
            string respuesta, cedula, continuar, rmenu;

            Console.WriteLine("Bienvenido a la aplicación");

            do
            {
                Console.WriteLine("Selecciones la acción a realizar");
                Console.WriteLine("1 para crear cuenta");
                Console.WriteLine("2 para consignar");
                Console.WriteLine("3 para retirar");
                Console.WriteLine("4 para consultar cuenta");
                Console.WriteLine("5 para listar las cuentas");
                Console.WriteLine("6 para eliminar cuenta");
                Console.WriteLine("7 para transferir");
                rmenu = Console.ReadLine();

                switch (rmenu)
                {
                    case "1":
                        Console.WriteLine("Por favor ingrese la cédula del titular de la cuenta");
                        cedula = Console.ReadLine();
                        comodin = CrearCuenta(cedula);
                        cuentas = AgregarALista(comodin, cuentas);
                        break;

                    case "2":
                        Console.WriteLine("Por favor ingrese la cédula del titular de la cuenta");
                        cedula = Console.ReadLine();
                        Console.WriteLine("Por favor ingrese la el valor a consignar");
                        aConsignar = float.Parse(Console.ReadLine());
                        ////////
                        break;
                    case "3":
                        Console.WriteLine("Por favor ingrese la cédula del titular de la cuenta");
                        cedula = Console.ReadLine();
                        Console.WriteLine("Por favor ingrese la el valor a retirar");
                        aRetirar = float.Parse(Console.ReadLine());
                        ////////
                        break;
                    case "4":
                        Console.WriteLine("Por favor ingrese la cédula del titular de la cuenta");
                        cedula = Console.ReadLine();
                        comodin = ConsultarCuenta(cedula, cuentas);
                        if(comodin != null)
                        {
                            ImprimirCuenta(comodin);
                        }
                        else
                        {
                            Console.WriteLine("Que pena, esa cuenta no la encontré");
                        }
                        break;
                    case "5":
                        ImprimirCuentas(cuentas);
                        break;
                }


                Console.WriteLine("¿Desea continuar haciendo algun proceso? (si o no)");
                continuar = Console.ReadLine();
            } while (continuar == "si");

            Console.ReadKey();
        }

        static void ImprimirCuentas(List<Cuenta> cuentas)
        {
            Console.WriteLine("Listando cuentas");
            Console.WriteLine("-------------------------\n");
            foreach (Cuenta iterador in cuentas)
            {
                Console.WriteLine("Titular: " + iterador.getTitular());
                Console.WriteLine("Saldo: " + iterador.getSaldo());
                Console.WriteLine("-------------------------\n");
            }
        }

        static void ImprimirCuenta(Cuenta elemento)
        {
            Console.WriteLine("Información cuentas");
            Console.WriteLine("Titular: " + elemento.getTitular());
            Console.WriteLine("Saldo: " + elemento.getSaldo());
            Console.WriteLine("-------------------------\n");
        }

        static Cuenta CrearCuenta(string titular)
        {
            Cuenta cuentica = new Cuenta(titular);
            return cuentica;
        }

        static List<Cuenta> AgregarALista(Cuenta elemento, List<Cuenta> lista)
        {
            string cedula = elemento.getTitular();
            Cuenta validadora = ConsultarCuenta(cedula, lista);
            if(validadora == null)
            {
                lista.Add(elemento);
            }
            return lista;
        }

        static Cuenta ConsultarCuenta(string cedula, List<Cuenta> cuentas)
        {
            foreach (Cuenta c in cuentas)
            {
                if (c.getTitular().Equals(cedula))
                {
                    return c;
                }
            }
            return null;
        }
    }
}
