using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.Delegados.Demo
{
    class Program
    {
        public delegate int Operacion(int iValor1, int iValor2);

        static void Main(string[] args)
        {
            int iResultado = 0;
            ConsoleKeyInfo input;
            do
            {
                MostrarMenu();
                input = Console.ReadKey();
                Boolean bEjecucion = true;

                switch (Convert.ToInt32(input.KeyChar))
                {
                    case 49:
                        iResultado = Funcion(Sumar,100, 7);
                        break;
                    case 50:
                        iResultado = Funcion(Restar,100, 7);
                        break;
                    default:
                        bEjecucion = false;
                        break;
                }
                if (bEjecucion) {
                    MostrarResultado(iResultado);
                    input = Console.ReadKey();
                }

            } while (input.Key != ConsoleKey.Escape);
        }

        static void MostrarMenu() {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("         --------------------");
            Console.WriteLine("         -- Menu Principal --");
            Console.WriteLine("         --------------------");
            Console.WriteLine(" [ 1 ]   Sumar ");
            Console.WriteLine(" [ 2 ]   Restar");
            Console.WriteLine(" [ 3 ]   Multiplicar");
            Console.WriteLine(" [ESC] = Salir");
            Console.WriteLine("");
            Console.Write("Seleccione una opción: ");
        }

        static void MostrarResultado(int iResultado)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("El resultado es : " + iResultado.ToString());
            Console.WriteLine("Pulsar una tecla para continuar...");
        }

        static int Funcion(Operacion ope, int iValor1, int iValor2)
        {
            return ope(iValor1,iValor2);
        }

        static int Sumar(int iValor1, int iValor2)
        {
            return iValor1 + iValor2;
        }

        static int Restar(int iValor1, int iValor2)
        {
            return iValor1 - iValor2;
        }
    }
}