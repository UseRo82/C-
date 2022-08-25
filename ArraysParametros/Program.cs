using System;

namespace ArraysParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            numeros[0] = 7;
            numeros[1] = 2;
            numeros[2] = 5;
            numeros[3] = 4;

            ProcesaDatos(numeros);

            foreach(int i in numeros)
            {
                Console.WriteLine(i);
            }
        }
        static void ProcesaDatos(int[] datos)
        {
            foreach(int i in datos)
            {
                Console.WriteLine(i);
            }

            //Añadiendo datos al array.
            for(int i = 0; i < 4; i++)
            {
                datos[i] += 10;
            }
        }
    }
}
