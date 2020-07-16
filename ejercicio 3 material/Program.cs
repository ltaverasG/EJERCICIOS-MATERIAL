using System;
using System.Security.Cryptography;
using System.Xml;

namespace ejercicio_3_material
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dias de la semana:");

            // array de los dias 
            string[] dias = { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };

            // imprimir los dias y dejar lineas 
            Console.WriteLine("\n Los dias de la semana son:\n");
            for (int i = 0; i < 7; i++)   // bucle 
            {
                Console.WriteLine("Posicion {0}: {1}", i, dias [i]);
            }

            Console.ReadKey();

        }
    }
}
