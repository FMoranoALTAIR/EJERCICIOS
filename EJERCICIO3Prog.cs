using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLog
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("################");
            Console.WriteLine("1. Cerrar");
            Console.WriteLine("2. Igualdad");
            Console.WriteLine("3. Desigualdad");
            Console.WriteLine("Seleccione una opción:");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Environment.Exit(0);
                    break;
                case 2:
                    Console.WriteLine("Ha seleccionado la opción igualdad");
                    Console.WriteLine("Introduzca la primera expresión:");
                    string expresion1 = Console.ReadLine();
                    Console.WriteLine("Introduzca la segunda expresión:");
                    string expresion2 = Console.ReadLine();
                    Console.WriteLine("Resultado de la igualdad: {0}", expresion1 == expresion2);
                    Console.WriteLine("################");
                    break;
                case 3:
                    Console.WriteLine("Ha seleccionado la opción desigualdad");
                    Console.WriteLine("Introduzca la primera expresión:");
                    expresion1 = Console.ReadLine();
                    Console.WriteLine("Introduzca la segunda expresión:");
                    expresion2 = Console.ReadLine();
                    Console.WriteLine("Resultado de la desigualdad: {0}", expresion1 != expresion2);
                    Console.WriteLine("################");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

            Console.ReadKey();
        }
    }
}

