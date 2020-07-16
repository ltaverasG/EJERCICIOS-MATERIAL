using System;
/*Un programa que pida al usuario 10 números, calcule su media 
 * y luego muestre los que están por encima de la media.*/
namespace EJERCICIO__7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE 10 NUMEROS ");

            // para ingresar los numeros y que se guarden en la variable 
            int[] numeros = new int [10];
            for ( int i = 0; i < 10; i ++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            // media de los numeros 
            int media = (numeros[0] + numeros[1] + numeros[2] + numeros[3] + numeros[5] + numeros[7] + numeros[8] + numeros[9]) / 10;
            Console.WriteLine("LA MEDIA DE LOS NUMEROS ES: " + media );
            Console.WriteLine("");

            // numeros mayores a la media 
            Console.WriteLine("LOS NUMEROS MAYORES A LA MEDIA SON:");

            foreach (int mayores_media in numeros )
            {
                if (mayores_media  > media)
                {
                    Console.WriteLine("Los numeros mayores al promedio son: " + mayores_media );
                }
            }
        }
    }
}
