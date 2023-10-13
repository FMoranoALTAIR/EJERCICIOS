using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class CalculadoraFMS
    {
        static void Main(string[] args)
        {
            // Mostrar el menú
            Console.WriteLine("Calculadora");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Cerrar");

            // Leer la opción del usuario
            int opcion = int.Parse(Console.ReadLine());

            // Realizar la operación
            double resultado = 0;
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Indique el primer operando:");
                    double operando1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Indique el segundo operando:");
                    double operando2 = double.Parse(Console.ReadLine());
                    resultado = operando1 + operando2;
                    break;
                case 2:
                    Console.WriteLine("Indique el primer operando:");
                    operando1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Indique el segundo operando:");
                    operando2 = double.Parse(Console.ReadLine());
                    resultado = operando1 - operando2;
                    break;
                case 3:
                    Console.WriteLine("Indique el primer operando:");
                    operando1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Indique el segundo operando:");
                    operando2 = double.Parse(Console.ReadLine());
                    resultado = operando1 * operando2;
                    break;
                case 4:
                    Console.WriteLine("Indique el primer operando:");
                    operando1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Indique el segundo operando:");
                    operando2 = double.Parse(Console.ReadLine());
                    resultado = operando1 / operando2;
                    break;
                case 5:
                    return;
            }

            // Mostrar el resultado
            Console.WriteLine("El resultado de la operacion es: {0}", resultado);

            // Volver a mostrar el menú
            Main(args);
        }
    }
}
