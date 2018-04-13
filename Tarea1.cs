using System;

class Program
{
    static void Main()
    {
        int[] Array;

        Console.Write("Cuantos numeros desea entrar? ");

        Array = new int[Int32.Parse(Console.ReadLine())];

        for (int i = 0; i < Array.Length; i++)
        {
            Console.Write("Escriba el numero " + (i + 1) + ":");
            Array[i] = Int32.Parse(Console.ReadLine());
            
        }

        Console.WriteLine("\n\nEl valor menor es " + ValorMinimo(Array));

        DemuestraArray(Array);
    }

    static int ValorMinimo(int[] Arraytemporero)
    {
        int Minimo = Arraytemporero[0];

        for (int i = 0; i < Arraytemporero.Length; i++)
        {
            if (Arraytemporero[i] < Minimo)
            {
                Minimo = Arraytemporero[i];
            }
        }

        return Minimo;
    }

    static void DemuestraArray(int[] Arraytemporero)
    {
        Console.WriteLine("\nLos elementos del aray son:");

        for (int i = 0; i < Arraytemporero.Length; i++)
        {
            Console.WriteLine(Arraytemporero[i]);
        }
    }
}