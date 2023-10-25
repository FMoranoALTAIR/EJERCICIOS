using System;

namespace NumeroCuadrado
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creamos una instancia del servicio
            Servicio servicio = new Servicio();

            // Solicitamos el número al usuario
            int numero = servicio.SolicitarNumero();

            if (Math.Sqrt(numero) % 1 == 0)
            {
                Console.WriteLine("El número {0} se puede expresar como el cuadrado de otro número entero", numero);
            }
            else
            {
                Console.WriteLine("El número {0} no se puede expresar como el cuadrado de otro número entero", numero);
            }
        }
    }

    public class Servicio
    {
        public int SolicitarNumero()
        {
            // Mostramos el mensaje de petición de número
            Console.WriteLine("Introduzca un número entero:");

            // Leemos el número escrito en la consola
            int numero = int.Parse(Console.ReadLine());

            // Devolvemos el número al método main
            return numero;
        }
    }
}
