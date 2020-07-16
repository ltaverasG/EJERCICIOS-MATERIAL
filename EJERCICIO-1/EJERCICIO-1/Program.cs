using Microsoft.VisualBasic;
using System;
/*Un programa que pida al usuario 4 números, los memorice (utilizando una tabla), 
 calcule su media aritmética y 
 después muestre en pantalla la media y los datos tecleados.
 */
namespace EJERCICIO_1
{
    class Program
    {
        static void Main(string[] args)
        {// variables 
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            int media;
  
            //proceso 
            Console.WriteLine("INGRESE 4 NUMEROS: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            // array de los numeros
            int[] array = new int[4];
            array[0] = n1;
            array[1] = n2;
            array[2] = n3;
            array[3] = n4;

            //media 
            media = (array[0] + array[1] + array[2] + array[3]) / 4;
            

            Console.WriteLine("La media de los numeros es: " + media);
            Console.WriteLine("");
            Console.WriteLine("Los numeros tecleados fueron:");
            // mostramos los datos de tecleados
            foreach (int i in array)

            Console.WriteLine( i );
            

        }
    }
}
