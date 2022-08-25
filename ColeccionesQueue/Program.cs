using System;
using System.Collections.Generic;

namespace ColeccionesQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();

            //Agregando elementos a la cola.
            foreach(int num in new int[3] { 1, 2, 3 })
            {
                numeros.Enqueue(num);
            }
            //Imprimiendo la cola.
            Console.WriteLine("Recorriendo el Queue.");

            foreach(int num in numeros)
            {
                Console.WriteLine(num);
            }
            //Eliminando elementos del Queue.
            Console.WriteLine("Eliminando elementos.");

            numeros.Dequeue();

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
        }
    }
}
