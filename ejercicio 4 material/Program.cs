
using System;

public class Ejercicio_4_material 
{
	public static void Main()
	{//variable

		// menu de los meses 
		Console.WriteLine("INGRESE UN NUMERO ");
		Console.WriteLine("");
		Console.WriteLine("1- ENERO  ");
		Console.WriteLine("2- FEBRERO ");
		Console.WriteLine("3- MARZO ");
		Console.WriteLine("4- ABRIL ");
		Console.WriteLine("5- MAYO ");
		Console.WriteLine("6- JUNIO ");
		Console.WriteLine("7- JULIO ");
		Console.WriteLine("8- AGOSTO ");
		Console.WriteLine("9- SEPTIEMBRE");
		Console.WriteLine("10- OCTUBRE");
		Console.WriteLine("11- NOVIEMBRE");
		Console.WriteLine("12- DICIEMBRE ");
		Console.WriteLine(" ");

		//array de los dias 
		int[]dias_M= new int[4];
		dias_M [1] = 31;
		dias_M [2] = 30;
		dias_M [3] = 28;

		// array de los meses 
		int[] meses = new int[13];
		meses[1] = dias_M [1];
		meses[2] = dias_M [3];
		meses[3] = dias_M [1];
		meses[4] = dias_M [2];
		meses[5] = dias_M [1];
		meses[6] = dias_M [2];
		meses[7] = dias_M [1];
		meses[8] = dias_M [1];
		meses[9] = dias_M [2];
		meses[10] = dias_M [1];
		meses[11] = dias_M [2];
		meses[12] = dias_M [1];


		// mostrar el resultado 
		int mes = 0;

		Console.WriteLine("INGRESE EL NUMERO DEL MES ");
		
		mes = Convert.ToInt32(Console.ReadLine());   // pedimos al usuario que ingrese el mes que desea saber los dias 
		Console.WriteLine ("El mes número " +  mes + "  tiene " + meses[mes] + " dias");

		Console.ReadKey();
	}
}