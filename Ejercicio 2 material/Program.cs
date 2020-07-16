using System;

namespace Ejercicio_2_material
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese 5 numeros reales: ");
            float[] array = new float[5];
            array[0] = 0;
            array[1] = 0;
            array[2] = 0;
            array[3] = 0;
            array[4] = 0;

            // ingrese los datos 
            array[0] = Convert.ToInt32(Console.ReadLine());
            array[1] = Convert.ToInt32(Console.ReadLine());
            array[2] = Convert.ToInt32(Console.ReadLine());
            array[3] = Convert.ToInt32(Console.ReadLine());
            array[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("En orden contrario: ");
            Array.Reverse(array);       // metodo para poner invertir el orden (de atras pa lante) 
            foreach (int i in array)
                Console.WriteLine(i);
          
        }
    }
}
